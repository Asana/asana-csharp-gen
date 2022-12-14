/*
 * Asana
 *
 * This is the interface for interacting with the [Asana Platform](https://developers.asana.com). Our API reference is generated from our [OpenAPI spec] (https://raw.githubusercontent.com/Asana/developer-docs/master/defs/asana_oas.yaml).
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using asana.Client;
using asana.Api;
using asana.Model;

namespace asana.Test
{
    /// <summary>
    ///  Class for testing StatusUpdatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class StatusUpdatesApiTests
    {
        private StatusUpdatesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StatusUpdatesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StatusUpdatesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' StatusUpdatesApi
            //Assert.IsInstanceOf(typeof(StatusUpdatesApi), instance);
        }

        
        /// <summary>
        /// Test CreateStatusForObject
        /// </summary>
        [Test]
        public void CreateStatusForObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateStatusForObjectRequest createStatusForObjectRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.CreateStatusForObject(createStatusForObjectRequest, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetStatus200Response), response, "response is GetStatus200Response");
        }
        
        /// <summary>
        /// Test DeleteStatus
        /// </summary>
        [Test]
        public void DeleteStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string statusGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.DeleteStatus(statusGid, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test GetStatus
        /// </summary>
        [Test]
        public void GetStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string statusGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.GetStatus(statusGid, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(GetStatus200Response), response, "response is GetStatus200Response");
        }
        
        /// <summary>
        /// Test GetStatusesForObject
        /// </summary>
        [Test]
        public void GetStatusesForObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string parent = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //DateTime? createdSince = null;
            //var response = instance.GetStatusesForObject(parent, optPretty, optFields, limit, offset, createdSince);
            //Assert.IsInstanceOf(typeof(GetStatusesForObject200Response), response, "response is GetStatusesForObject200Response");
        }
        
    }

}
