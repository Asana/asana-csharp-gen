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
    ///  Class for testing GoalRelationshipsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GoalRelationshipsApiTests
    {
        private GoalRelationshipsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GoalRelationshipsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GoalRelationshipsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' GoalRelationshipsApi
            //Assert.IsInstanceOf(typeof(GoalRelationshipsApi), instance);
        }

        
        /// <summary>
        /// Test AddSupportingRelationship
        /// </summary>
        [Test]
        public void AddSupportingRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string goalGid = null;
            //AddSupportingRelationshipRequest addSupportingRelationshipRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.AddSupportingRelationship(goalGid, addSupportingRelationshipRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(GetGoalRelationship200Response), response, "response is GetGoalRelationship200Response");
        }
        
        /// <summary>
        /// Test GetGoalRelationship
        /// </summary>
        [Test]
        public void GetGoalRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string goalRelationshipGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.GetGoalRelationship(goalRelationshipGid, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(GetGoalRelationship200Response), response, "response is GetGoalRelationship200Response");
        }
        
        /// <summary>
        /// Test GetGoalRelationships
        /// </summary>
        [Test]
        public void GetGoalRelationshipsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string supportedGoal = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //string resourceSubtype = null;
            //var response = instance.GetGoalRelationships(supportedGoal, optPretty, optFields, resourceSubtype);
            //Assert.IsInstanceOf(typeof(GetGoalRelationships200Response), response, "response is GetGoalRelationships200Response");
        }
        
        /// <summary>
        /// Test RemoveSupportingRelationship
        /// </summary>
        [Test]
        public void RemoveSupportingRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string goalGid = null;
            //RemoveSupportingRelationshipRequest removeSupportingRelationshipRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.RemoveSupportingRelationship(goalGid, removeSupportingRelationshipRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test UpdateGoalRelationship
        /// </summary>
        [Test]
        public void UpdateGoalRelationshipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string goalRelationshipGid = null;
            //UpdateGoalRelationshipRequest updateGoalRelationshipRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.UpdateGoalRelationship(goalRelationshipGid, updateGoalRelationshipRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(GetGoalRelationship200Response), response, "response is GetGoalRelationship200Response");
        }
        
    }

}