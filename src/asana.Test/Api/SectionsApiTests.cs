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
    ///  Class for testing SectionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SectionsApiTests
    {
        private SectionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SectionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SectionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' SectionsApi
            //Assert.IsInstanceOf(typeof(SectionsApi), instance);
        }

        
        /// <summary>
        /// Test AddTaskForSection
        /// </summary>
        [Test]
        public void AddTaskForSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sectionGid = null;
            //AddTaskForSectionRequest addTaskForSectionRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.AddTaskForSection(sectionGid, addTaskForSectionRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test CreateSectionForProject
        /// </summary>
        [Test]
        public void CreateSectionForProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectGid = null;
            //UpdateSectionRequest updateSectionRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.CreateSectionForProject(projectGid, updateSectionRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(GetSection200Response), response, "response is GetSection200Response");
        }
        
        /// <summary>
        /// Test DeleteSection
        /// </summary>
        [Test]
        public void DeleteSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sectionGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.DeleteSection(sectionGid, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test GetSection
        /// </summary>
        [Test]
        public void GetSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sectionGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.GetSection(sectionGid, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(GetSection200Response), response, "response is GetSection200Response");
        }
        
        /// <summary>
        /// Test GetSectionsForProject
        /// </summary>
        [Test]
        public void GetSectionsForProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetSectionsForProject(projectGid, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetSectionsForProject200Response), response, "response is GetSectionsForProject200Response");
        }
        
        /// <summary>
        /// Test InsertSectionForProject
        /// </summary>
        [Test]
        public void InsertSectionForProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectGid = null;
            //InsertSectionForProjectRequest insertSectionForProjectRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.InsertSectionForProject(projectGid, insertSectionForProjectRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test UpdateSection
        /// </summary>
        [Test]
        public void UpdateSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sectionGid = null;
            //UpdateSectionRequest updateSectionRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.UpdateSection(sectionGid, updateSectionRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(GetSection200Response), response, "response is GetSection200Response");
        }
        
    }

}
