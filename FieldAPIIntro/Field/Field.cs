#region Copyright
//
// Copyright (C) 2015 by Autodesk, Inc.
//
// Permission to use, copy, modify, and distribute this software in
// object code form for any purpose and without fee is hereby granted,
// provided that the above copyright notice appears in all copies and
// that both that copyright notice and the limited warranty and
// restricted rights notice below appear in all supporting
// documentation.
//
// AUTODESK PROVIDES THIS PROGRAM "AS IS" AND WITH ALL FAULTS.
// AUTODESK SPECIFICALLY DISCLAIMS ANY IMPLIED WARRANTY OF
// MERCHANTABILITY OR FITNESS FOR A PARTICULAR USE.  AUTODESK, INC.
// DOES NOT WARRANT THAT THE OPERATION OF THE PROGRAM WILL BE
// UNINTERRUPTED OR ERROR FREE.
//
// Use, duplication, or disclosure by the U.S. Government is subject to
// restrictions set forth in FAR 52.227-19 (Commercial Computer
// Software - Restricted Rights) and DFAR 252.227-7013(c)(1)(ii)
// (Rights in Technical Data and Computer Software), as applicable.
//
// Written by M.Harada
// 
#endregion // Copyright

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; // for HttpStatusCode 
using System.Diagnostics; // for debugging 
using System.IO;
using System.Web; 
// Added for RestSharp 
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;  

namespace HelloFieldWorld
{
    class Field
    {
        // Constants 
        private const string _baseUrl = @"https://bim360field.autodesk.com";

        // Member variables 
        // Save the last response. This is for learning purpose. 
        public static IRestResponse m_lastResponse = null; 

        ///===================================================
        /// Login
        /// URL:  
        /// https://bim360field.autodesk.com/api/login
        /// Method: POST
        /// Description: 
        /// Authenticate using BIM 360 Field credentials. 
        /// On success, returns a 36 byte GUID "ticket" which  
        /// needs to be passed in on subsequent calls.
        /// Doc
        /// https://bim360field.autodesk.com/apidoc/index.html
        /// 
        /// Sample Response (JSON) 
        /// {"ticket":"0054444d-be79-1345-6657-45422efd9d80","message":"","title":""}
        /// 
        ///===================================================
        public static string Login(string userName, string password)
        {
            // (1) Build request 
            var client = new RestClient();
            client.BaseUrl = new System.Uri(_baseUrl);

            // Set resource/end point 
            var request = new RestRequest();
            request.Resource = "/api/login";
            request.Method = Method.POST;

            // Set required parameters 
            request.AddParameter("username", userName);
            request.AddParameter("password", password); 

            // (2) Execute request and get response
            IRestResponse response = client.Execute(request);

            // Save response. This is to see the response for our learning.
            m_lastResponse = response;

            // (3) Parse the response and get the ticket. 
            string ticket = "";
            if (response.StatusCode == HttpStatusCode.OK)
            {
                JsonDeserializer deserial = new JsonDeserializer();
                LoginResponse loginResponse = deserial.Deserialize<LoginResponse>(response);
                ticket = loginResponse.ticket; 
            }

            return ticket; 
        }

        ///==================================================
        /// <summary>
        /// /fieldapi/admin/v1/project_names
        /// Get a list of project names  
        /// URL:  
        /// https://bim360field.autodesk.com/fieldapi/admin/v1/project_names
        /// Method: POST
        /// Description: 
        /// Get a list of project names and project identifiers  
        /// that are asscociated with the account.
        /// Doc
        /// https://bim360field.autodesk.com/apidoc/index.html#admin_api_method_3
        /// 
        /// Sample Response (JSON)
        /// [
        ///   {"id" : "12345678-12312-12313-1231312","name" : "Sonoma House","a360_project_id" : null,"updated_at" : "2013-07-10T12:30:10Z"},
        ///   {"id" : "67236712-23112-87777-9999991","name" : Zip Energy Center - Cx","a360_project_id" : "ABC123GHI","updated_at" : "2013-07-10T12:30:10Z"}
        /// ]
        ///
        /// </summary>
        /// <returns></returns>
        /// =================================================
        public static List<Project> ProjectNames(string ticket)
        {
            // (1) Build request 
            var client = new RestClient();
            client.BaseUrl = new System.Uri(_baseUrl);

            // Set resource or end point 
            var request = new RestRequest();
            request.Resource = "/fieldapi/admin/v1/project_names";
            request.Method = Method.POST;

            // Add parameters 
            request.AddParameter("ticket", ticket);

            // (2) Execute request and get response
            IRestResponse response = client.Execute(request);

            // Save response. This is to see the response for our learning.
            m_lastResponse = response;

            // (3) Parse the response and get the list of projects. 
            
            if (response.StatusCode != HttpStatusCode.OK)
            {
                return null; 
            }

            JsonDeserializer deserial = new JsonDeserializer();
            List<Project> proj_list = deserial.Deserialize<List<Project>>(response);

            return proj_list;
        }

        public static List<Equipment> GetEquipments(string ticket, string project_id)
        {
            // (1) Build request 
            var client = new RestClient();
            client.BaseUrl = new System.Uri(_baseUrl);

            // Set resource or end point 
            var request = new RestRequest();
            request.Resource = "/api/get_equipment";
            request.Method = Method.POST;

            // Add parameters 
            request.AddParameter("ticket", ticket);
            request.AddParameter("project_id", project_id);

            // (2) Execute request and get response
            IRestResponse response = client.Execute(request);

            // Save response. This is to see the response for our learning.
            m_lastResponse = response;

            // (3) Parse the response and get the list of projects. 

            if (response.StatusCode != HttpStatusCode.OK)
            {
                return null;
            }

            JsonDeserializer deserial = new JsonDeserializer();
            List<Equipment> equipment_list = deserial.Deserialize<List<Equipment>>(response);

            return equipment_list;
        }


        ///==================================================
        /// <summary>
        /// POST /api/attachments
        /// Upload or delete an attachment   
        /// URL:  
        /// https://bim360field.autodesk.com/api/attachments
        /// Method: POST
        /// Description: 
        /// Uploads an attachment, or asks the server to delete an existing attachment.
        /// Doc      
        /// https://bim360field.autodesk.com/apidoc/index.html#mobile_api_method_21
        /// </summary>
        /// <returns></returns>
        /// =================================================

        public static string Attachments(string ticket, string project_id,
            string originalPath, string thumbPath, 
            string container_id, string container_type)
        {
            // (1) Build request 
            var client = new RestClient();
            client.BaseUrl = new System.Uri(_baseUrl);

            // Set resource or end point 
            var request = new RestRequest();
            request.Resource = "/api/attachments";
            request.Method = Method.POST;

            // Add parameters 
            request.AddParameter("ticket", ticket);
            request.AddParameter("project_id", project_id);

            // Compose Attachment JSON string 
            FileInfo original = new FileInfo(originalPath);
            Dictionary<string, string> att = new Dictionary<string, string>();

            // date time format: "2015-08-05 15:28:17 -0500";
            string dateTimeFormat = "yyyy-MM-dd HH:mm:ss zzz";
            string curTime = DateTime.Now.ToString(dateTimeFormat);
            att["fcreate_date"] = original.CreationTime.ToString(dateTimeFormat);
            att["fmod_date"] = original.LastWriteTime.ToString(dateTimeFormat);
            att["created_at"] = curTime;
            att["updated_at"] = curTime;

            att["size"] = original.Length.ToString();
            att["content_type"] = MimeMapping.GetMimeMapping(original.Name);
            att["filename"] = original.Name;
            att["container_id"] = container_id;     // e.g., equipment_id 
            att["container_type"] = container_type; // e.g., "Equipment" 

            // Conver to JSON format
            JsonSerializer JsonSerial = new JsonSerializer();
            string attachment = JsonSerial.Serialize(att);
            Debug.WriteLine("attachment parameter = " + attachment);

            request.AddParameter("attachment", attachment);

            // Add Files 
            request.AddFile("original", originalPath);
            request.AddFile("thumb", thumbPath); // MH: looks like it works without it. 

            // (2) Execute request and get response
            IRestResponse response = client.Execute(request);

            // Save response. This is to see the response for our learning.
            m_lastResponse = response; 

            return response.StatusCode.ToString();   
        }
    }
}
