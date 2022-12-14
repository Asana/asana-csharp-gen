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
    ///  Class for testing AuditLogAPIApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuditLogAPIApiTests
    {
        private AuditLogAPIApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AuditLogAPIApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AuditLogAPIApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' AuditLogAPIApi
            //Assert.IsInstanceOf(typeof(AuditLogAPIApi), instance);
        }

        
        /// <summary>
        /// Test GetAuditLogEvents
        /// </summary>
        [Test]
        public void GetAuditLogEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workspaceGid = null;
            //DateTime? startAt = null;
            //DateTime? endAt = null;
            //string eventType = null;
            //string actorType = null;
            //string actorGid = null;
            //string resourceGid = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetAuditLogEvents(workspaceGid, startAt, endAt, eventType, actorType, actorGid, resourceGid, limit, offset);
            //Assert.IsInstanceOf(typeof(GetAuditLogEvents200Response), response, "response is GetAuditLogEvents200Response");
        }
        
    }

}
