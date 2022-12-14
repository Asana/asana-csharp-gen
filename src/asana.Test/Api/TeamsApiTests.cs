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
    ///  Class for testing TeamsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TeamsApiTests
    {
        private TeamsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TeamsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeamsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TeamsApi
            //Assert.IsInstanceOf(typeof(TeamsApi), instance);
        }

        
        /// <summary>
        /// Test AddUserForTeam
        /// </summary>
        [Test]
        public void AddUserForTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamGid = null;
            //AddUserForTeamRequest addUserForTeamRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.AddUserForTeam(teamGid, addUserForTeamRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(GetTeamMembership200Response), response, "response is GetTeamMembership200Response");
        }
        
        /// <summary>
        /// Test CreateTeam
        /// </summary>
        [Test]
        public void CreateTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateTeamRequest updateTeamRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.CreateTeam(updateTeamRequest, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(UpdateTeam200Response), response, "response is UpdateTeam200Response");
        }
        
        /// <summary>
        /// Test GetTeam
        /// </summary>
        [Test]
        public void GetTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetTeam(teamGid, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(UpdateTeam200Response), response, "response is UpdateTeam200Response");
        }
        
        /// <summary>
        /// Test GetTeamsForUser
        /// </summary>
        [Test]
        public void GetTeamsForUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userGid = null;
            //string organization = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetTeamsForUser(userGid, organization, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetTeamsForWorkspace200Response), response, "response is GetTeamsForWorkspace200Response");
        }
        
        /// <summary>
        /// Test GetTeamsForWorkspace
        /// </summary>
        [Test]
        public void GetTeamsForWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workspaceGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetTeamsForWorkspace(workspaceGid, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetTeamsForWorkspace200Response), response, "response is GetTeamsForWorkspace200Response");
        }
        
        /// <summary>
        /// Test RemoveUserForTeam
        /// </summary>
        [Test]
        public void RemoveUserForTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string teamGid = null;
            //RemoveUserForTeamRequest removeUserForTeamRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.RemoveUserForTeam(teamGid, removeUserForTeamRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test UpdateTeam
        /// </summary>
        [Test]
        public void UpdateTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateTeamRequest updateTeamRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.UpdateTeam(updateTeamRequest, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(UpdateTeam200Response), response, "response is UpdateTeam200Response");
        }
        
    }

}
