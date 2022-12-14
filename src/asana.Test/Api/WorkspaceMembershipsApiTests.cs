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
    ///  Class for testing WorkspaceMembershipsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WorkspaceMembershipsApiTests
    {
        private WorkspaceMembershipsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkspaceMembershipsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WorkspaceMembershipsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' WorkspaceMembershipsApi
            //Assert.IsInstanceOf(typeof(WorkspaceMembershipsApi), instance);
        }

        
        /// <summary>
        /// Test GetWorkspaceMembership
        /// </summary>
        [Test]
        public void GetWorkspaceMembershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workspaceMembershipGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.GetWorkspaceMembership(workspaceMembershipGid, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(GetWorkspaceMembership200Response), response, "response is GetWorkspaceMembership200Response");
        }
        
        /// <summary>
        /// Test GetWorkspaceMembershipsForUser
        /// </summary>
        [Test]
        public void GetWorkspaceMembershipsForUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetWorkspaceMembershipsForUser(userGid, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetWorkspaceMembershipsForUser200Response), response, "response is GetWorkspaceMembershipsForUser200Response");
        }
        
        /// <summary>
        /// Test GetWorkspaceMembershipsForWorkspace
        /// </summary>
        [Test]
        public void GetWorkspaceMembershipsForWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workspaceGid = null;
            //string user = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetWorkspaceMembershipsForWorkspace(workspaceGid, user, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetWorkspaceMembershipsForUser200Response), response, "response is GetWorkspaceMembershipsForUser200Response");
        }
        
    }

}
