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
    ///  Class for testing ProjectMembershipsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProjectMembershipsApiTests
    {
        private ProjectMembershipsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProjectMembershipsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProjectMembershipsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ProjectMembershipsApi
            //Assert.IsInstanceOf(typeof(ProjectMembershipsApi), instance);
        }

        
        /// <summary>
        /// Test GetProjectMembership
        /// </summary>
        [Test]
        public void GetProjectMembershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectMembershipGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.GetProjectMembership(projectMembershipGid, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(GetProjectMembership200Response), response, "response is GetProjectMembership200Response");
        }
        
        /// <summary>
        /// Test GetProjectMembershipsForProject
        /// </summary>
        [Test]
        public void GetProjectMembershipsForProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectGid = null;
            //string user = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetProjectMembershipsForProject(projectGid, user, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetProjectMembershipsForProject200Response), response, "response is GetProjectMembershipsForProject200Response");
        }
        
    }

}