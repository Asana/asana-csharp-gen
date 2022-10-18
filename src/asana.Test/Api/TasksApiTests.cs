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
    ///  Class for testing TasksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TasksApiTests
    {
        private TasksApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TasksApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TasksApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TasksApi
            //Assert.IsInstanceOf(typeof(TasksApi), instance);
        }

        
        /// <summary>
        /// Test AddDependenciesForTask
        /// </summary>
        [Test]
        public void AddDependenciesForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddDependenciesForTaskRequest addDependenciesForTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.AddDependenciesForTask(taskGid, addDependenciesForTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test AddDependentsForTask
        /// </summary>
        [Test]
        public void AddDependentsForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddDependentsForTaskRequest addDependentsForTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.AddDependentsForTask(taskGid, addDependentsForTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test AddFollowersForTask
        /// </summary>
        [Test]
        public void AddFollowersForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddFollowersRequest addFollowersRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.AddFollowersForTask(taskGid, addFollowersRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(CreateTask201Response), response, "response is CreateTask201Response");
        }
        
        /// <summary>
        /// Test AddProjectForTask
        /// </summary>
        [Test]
        public void AddProjectForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddProjectForTaskRequest addProjectForTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.AddProjectForTask(taskGid, addProjectForTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test AddTagForTask
        /// </summary>
        [Test]
        public void AddTagForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddTagForTaskRequest addTagForTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.AddTagForTask(taskGid, addTagForTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test CreateSubtaskForTask
        /// </summary>
        [Test]
        public void CreateSubtaskForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //CreateTaskRequest createTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.CreateSubtaskForTask(taskGid, createTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(CreateTask201Response), response, "response is CreateTask201Response");
        }
        
        /// <summary>
        /// Test CreateTask
        /// </summary>
        [Test]
        public void CreateTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTaskRequest createTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.CreateTask(createTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(CreateTask201Response), response, "response is CreateTask201Response");
        }
        
        /// <summary>
        /// Test DeleteTask
        /// </summary>
        [Test]
        public void DeleteTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.DeleteTask(taskGid, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test DuplicateTask
        /// </summary>
        [Test]
        public void DuplicateTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //DuplicateTaskRequest duplicateTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.DuplicateTask(taskGid, duplicateTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(GetJob200Response), response, "response is GetJob200Response");
        }
        
        /// <summary>
        /// Test GetDependenciesForTask
        /// </summary>
        [Test]
        public void GetDependenciesForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetDependenciesForTask(taskGid, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetTasks200Response), response, "response is GetTasks200Response");
        }
        
        /// <summary>
        /// Test GetDependentsForTask
        /// </summary>
        [Test]
        public void GetDependentsForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetDependentsForTask(taskGid, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetTasks200Response), response, "response is GetTasks200Response");
        }
        
        /// <summary>
        /// Test GetSubtasksForTask
        /// </summary>
        [Test]
        public void GetSubtasksForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetSubtasksForTask(taskGid, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetTasks200Response), response, "response is GetTasks200Response");
        }
        
        /// <summary>
        /// Test GetTask
        /// </summary>
        [Test]
        public void GetTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.GetTask(taskGid, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(CreateTask201Response), response, "response is CreateTask201Response");
        }
        
        /// <summary>
        /// Test GetTasks
        /// </summary>
        [Test]
        public void GetTasksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //string assignee = null;
            //string project = null;
            //string section = null;
            //string workspace = null;
            //DateTime? completedSince = null;
            //DateTime? modifiedSince = null;
            //var response = instance.GetTasks(optPretty, optFields, limit, offset, assignee, project, section, workspace, completedSince, modifiedSince);
            //Assert.IsInstanceOf(typeof(GetTasks200Response), response, "response is GetTasks200Response");
        }
        
        /// <summary>
        /// Test GetTasksForProject
        /// </summary>
        [Test]
        public void GetTasksForProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectGid = null;
            //string completedSince = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetTasksForProject(projectGid, completedSince, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetTasks200Response), response, "response is GetTasks200Response");
        }
        
        /// <summary>
        /// Test GetTasksForSection
        /// </summary>
        [Test]
        public void GetTasksForSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sectionGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetTasksForSection(sectionGid, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetTasks200Response), response, "response is GetTasks200Response");
        }
        
        /// <summary>
        /// Test GetTasksForTag
        /// </summary>
        [Test]
        public void GetTasksForTagTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tagGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetTasksForTag(tagGid, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetTasks200Response), response, "response is GetTasks200Response");
        }
        
        /// <summary>
        /// Test GetTasksForUserTaskList
        /// </summary>
        [Test]
        public void GetTasksForUserTaskListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userTaskListGid = null;
            //string completedSince = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //int? limit = null;
            //string offset = null;
            //var response = instance.GetTasksForUserTaskList(userTaskListGid, completedSince, optPretty, optFields, limit, offset);
            //Assert.IsInstanceOf(typeof(GetTasks200Response), response, "response is GetTasks200Response");
        }
        
        /// <summary>
        /// Test RemoveDependenciesForTask
        /// </summary>
        [Test]
        public void RemoveDependenciesForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddDependenciesForTaskRequest addDependenciesForTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.RemoveDependenciesForTask(taskGid, addDependenciesForTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test RemoveDependentsForTask
        /// </summary>
        [Test]
        public void RemoveDependentsForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //AddDependentsForTaskRequest addDependentsForTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.RemoveDependentsForTask(taskGid, addDependentsForTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test RemoveFollowerForTask
        /// </summary>
        [Test]
        public void RemoveFollowerForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //RemoveFollowerForTaskRequest removeFollowerForTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.RemoveFollowerForTask(taskGid, removeFollowerForTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(CreateTask201Response), response, "response is CreateTask201Response");
        }
        
        /// <summary>
        /// Test RemoveProjectForTask
        /// </summary>
        [Test]
        public void RemoveProjectForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //RemoveProjectForTaskRequest removeProjectForTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.RemoveProjectForTask(taskGid, removeProjectForTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test RemoveTagForTask
        /// </summary>
        [Test]
        public void RemoveTagForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //RemoveTagForTaskRequest removeTagForTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.RemoveTagForTask(taskGid, removeTagForTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(DeleteAttachment200Response), response, "response is DeleteAttachment200Response");
        }
        
        /// <summary>
        /// Test SearchTasksForWorkspace
        /// </summary>
        [Test]
        public void SearchTasksForWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workspaceGid = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //string text = null;
            //string resourceSubtype = null;
            //string assigneeAny = null;
            //string assigneeNot = null;
            //string portfoliosAny = null;
            //string projectsAny = null;
            //string projectsNot = null;
            //string projectsAll = null;
            //string sectionsAny = null;
            //string sectionsNot = null;
            //string sectionsAll = null;
            //string tagsAny = null;
            //string tagsNot = null;
            //string tagsAll = null;
            //string teamsAny = null;
            //string followersNot = null;
            //string createdByAny = null;
            //string createdByNot = null;
            //string assignedByAny = null;
            //string assignedByNot = null;
            //string likedByNot = null;
            //string commentedOnByNot = null;
            //DateTime? dueOnBefore = null;
            //DateTime? dueOnAfter = null;
            //DateTime? dueOn = null;
            //DateTime? dueAtBefore = null;
            //DateTime? dueAtAfter = null;
            //DateTime? startOnBefore = null;
            //DateTime? startOnAfter = null;
            //DateTime? startOn = null;
            //DateTime? createdOnBefore = null;
            //DateTime? createdOnAfter = null;
            //DateTime? createdOn = null;
            //DateTime? createdAtBefore = null;
            //DateTime? createdAtAfter = null;
            //DateTime? completedOnBefore = null;
            //DateTime? completedOnAfter = null;
            //DateTime? completedOn = null;
            //DateTime? completedAtBefore = null;
            //DateTime? completedAtAfter = null;
            //DateTime? modifiedOnBefore = null;
            //DateTime? modifiedOnAfter = null;
            //DateTime? modifiedOn = null;
            //DateTime? modifiedAtBefore = null;
            //DateTime? modifiedAtAfter = null;
            //bool? isBlocking = null;
            //bool? isBlocked = null;
            //bool? hasAttachment = null;
            //bool? completed = null;
            //bool? isSubtask = null;
            //string sortBy = null;
            //bool? sortAscending = null;
            //var response = instance.SearchTasksForWorkspace(workspaceGid, optPretty, optFields, text, resourceSubtype, assigneeAny, assigneeNot, portfoliosAny, projectsAny, projectsNot, projectsAll, sectionsAny, sectionsNot, sectionsAll, tagsAny, tagsNot, tagsAll, teamsAny, followersNot, createdByAny, createdByNot, assignedByAny, assignedByNot, likedByNot, commentedOnByNot, dueOnBefore, dueOnAfter, dueOn, dueAtBefore, dueAtAfter, startOnBefore, startOnAfter, startOn, createdOnBefore, createdOnAfter, createdOn, createdAtBefore, createdAtAfter, completedOnBefore, completedOnAfter, completedOn, completedAtBefore, completedAtAfter, modifiedOnBefore, modifiedOnAfter, modifiedOn, modifiedAtBefore, modifiedAtAfter, isBlocking, isBlocked, hasAttachment, completed, isSubtask, sortBy, sortAscending);
            //Assert.IsInstanceOf(typeof(GetTasks200Response), response, "response is GetTasks200Response");
        }
        
        /// <summary>
        /// Test SetParentForTask
        /// </summary>
        [Test]
        public void SetParentForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //SetParentForTaskRequest setParentForTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.SetParentForTask(taskGid, setParentForTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(CreateTask201Response), response, "response is CreateTask201Response");
        }
        
        /// <summary>
        /// Test UpdateTask
        /// </summary>
        [Test]
        public void UpdateTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //CreateTaskRequest createTaskRequest = null;
            //bool? optPretty = null;
            //List<string> optFields = null;
            //var response = instance.UpdateTask(taskGid, createTaskRequest, optPretty, optFields);
            //Assert.IsInstanceOf(typeof(CreateTask201Response), response, "response is CreateTask201Response");
        }
        
    }

}
