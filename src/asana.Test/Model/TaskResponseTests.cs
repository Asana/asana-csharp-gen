/*
 * Asana
 *
 * This is the interface for interacting with the [Asana Platform](https://developers.asana.com). Our API reference is generated from our [OpenAPI spec] (https://raw.githubusercontent.com/Asana/developer-docs/master/defs/asana_oas.yaml).
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using asana.Api;
using asana.Model;
using asana.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace asana.Test
{
    /// <summary>
    ///  Class for testing TaskResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TaskResponseTests
    {
        // TODO uncomment below to declare an instance variable for TaskResponse
        //private TaskResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TaskResponse
            //instance = new TaskResponse();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TaskResponse
        /// </summary>
        [Test]
        public void TaskResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" TaskResponse
            //Assert.IsInstanceOf(typeof(TaskResponse), instance);
        }


        /// <summary>
        /// Test the property 'Gid'
        /// </summary>
        [Test]
        public void GidTest()
        {
            // TODO unit test for the property 'Gid'
        }
        /// <summary>
        /// Test the property 'ResourceType'
        /// </summary>
        [Test]
        public void ResourceTypeTest()
        {
            // TODO unit test for the property 'ResourceType'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'ResourceSubtype'
        /// </summary>
        [Test]
        public void ResourceSubtypeTest()
        {
            // TODO unit test for the property 'ResourceSubtype'
        }
        /// <summary>
        /// Test the property 'ApprovalStatus'
        /// </summary>
        [Test]
        public void ApprovalStatusTest()
        {
            // TODO unit test for the property 'ApprovalStatus'
        }
        /// <summary>
        /// Test the property 'AssigneeStatus'
        /// </summary>
        [Test]
        public void AssigneeStatusTest()
        {
            // TODO unit test for the property 'AssigneeStatus'
        }
        /// <summary>
        /// Test the property 'Completed'
        /// </summary>
        [Test]
        public void CompletedTest()
        {
            // TODO unit test for the property 'Completed'
        }
        /// <summary>
        /// Test the property 'CompletedAt'
        /// </summary>
        [Test]
        public void CompletedAtTest()
        {
            // TODO unit test for the property 'CompletedAt'
        }
        /// <summary>
        /// Test the property 'CompletedBy'
        /// </summary>
        [Test]
        public void CompletedByTest()
        {
            // TODO unit test for the property 'CompletedBy'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'Dependencies'
        /// </summary>
        [Test]
        public void DependenciesTest()
        {
            // TODO unit test for the property 'Dependencies'
        }
        /// <summary>
        /// Test the property 'Dependents'
        /// </summary>
        [Test]
        public void DependentsTest()
        {
            // TODO unit test for the property 'Dependents'
        }
        /// <summary>
        /// Test the property 'DueAt'
        /// </summary>
        [Test]
        public void DueAtTest()
        {
            // TODO unit test for the property 'DueAt'
        }
        /// <summary>
        /// Test the property 'DueOn'
        /// </summary>
        [Test]
        public void DueOnTest()
        {
            // TODO unit test for the property 'DueOn'
        }
        /// <summary>
        /// Test the property 'External'
        /// </summary>
        [Test]
        public void ExternalTest()
        {
            // TODO unit test for the property 'External'
        }
        /// <summary>
        /// Test the property 'HtmlNotes'
        /// </summary>
        [Test]
        public void HtmlNotesTest()
        {
            // TODO unit test for the property 'HtmlNotes'
        }
        /// <summary>
        /// Test the property 'Hearted'
        /// </summary>
        [Test]
        public void HeartedTest()
        {
            // TODO unit test for the property 'Hearted'
        }
        /// <summary>
        /// Test the property 'Hearts'
        /// </summary>
        [Test]
        public void HeartsTest()
        {
            // TODO unit test for the property 'Hearts'
        }
        /// <summary>
        /// Test the property 'IsRenderedAsSeparator'
        /// </summary>
        [Test]
        public void IsRenderedAsSeparatorTest()
        {
            // TODO unit test for the property 'IsRenderedAsSeparator'
        }
        /// <summary>
        /// Test the property 'Liked'
        /// </summary>
        [Test]
        public void LikedTest()
        {
            // TODO unit test for the property 'Liked'
        }
        /// <summary>
        /// Test the property 'Likes'
        /// </summary>
        [Test]
        public void LikesTest()
        {
            // TODO unit test for the property 'Likes'
        }
        /// <summary>
        /// Test the property 'Memberships'
        /// </summary>
        [Test]
        public void MembershipsTest()
        {
            // TODO unit test for the property 'Memberships'
        }
        /// <summary>
        /// Test the property 'ModifiedAt'
        /// </summary>
        [Test]
        public void ModifiedAtTest()
        {
            // TODO unit test for the property 'ModifiedAt'
        }
        /// <summary>
        /// Test the property 'Notes'
        /// </summary>
        [Test]
        public void NotesTest()
        {
            // TODO unit test for the property 'Notes'
        }
        /// <summary>
        /// Test the property 'NumHearts'
        /// </summary>
        [Test]
        public void NumHeartsTest()
        {
            // TODO unit test for the property 'NumHearts'
        }
        /// <summary>
        /// Test the property 'NumLikes'
        /// </summary>
        [Test]
        public void NumLikesTest()
        {
            // TODO unit test for the property 'NumLikes'
        }
        /// <summary>
        /// Test the property 'NumSubtasks'
        /// </summary>
        [Test]
        public void NumSubtasksTest()
        {
            // TODO unit test for the property 'NumSubtasks'
        }
        /// <summary>
        /// Test the property 'StartAt'
        /// </summary>
        [Test]
        public void StartAtTest()
        {
            // TODO unit test for the property 'StartAt'
        }
        /// <summary>
        /// Test the property 'StartOn'
        /// </summary>
        [Test]
        public void StartOnTest()
        {
            // TODO unit test for the property 'StartOn'
        }
        /// <summary>
        /// Test the property 'Assignee'
        /// </summary>
        [Test]
        public void AssigneeTest()
        {
            // TODO unit test for the property 'Assignee'
        }
        /// <summary>
        /// Test the property 'AssigneeSection'
        /// </summary>
        [Test]
        public void AssigneeSectionTest()
        {
            // TODO unit test for the property 'AssigneeSection'
        }
        /// <summary>
        /// Test the property 'CustomFields'
        /// </summary>
        [Test]
        public void CustomFieldsTest()
        {
            // TODO unit test for the property 'CustomFields'
        }
        /// <summary>
        /// Test the property 'Followers'
        /// </summary>
        [Test]
        public void FollowersTest()
        {
            // TODO unit test for the property 'Followers'
        }
        /// <summary>
        /// Test the property 'Parent'
        /// </summary>
        [Test]
        public void ParentTest()
        {
            // TODO unit test for the property 'Parent'
        }
        /// <summary>
        /// Test the property 'Projects'
        /// </summary>
        [Test]
        public void ProjectsTest()
        {
            // TODO unit test for the property 'Projects'
        }
        /// <summary>
        /// Test the property 'Tags'
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO unit test for the property 'Tags'
        }
        /// <summary>
        /// Test the property 'Workspace'
        /// </summary>
        [Test]
        public void WorkspaceTest()
        {
            // TODO unit test for the property 'Workspace'
        }
        /// <summary>
        /// Test the property 'PermalinkUrl'
        /// </summary>
        [Test]
        public void PermalinkUrlTest()
        {
            // TODO unit test for the property 'PermalinkUrl'
        }

    }

}
