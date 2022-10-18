
# asana.Model.ProjectResponseAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomFields** | [**List&lt;CustomFieldCompact&gt;**](CustomFieldCompact.md) | Array of Custom Fields. | [optional] [readonly] 
**Completed** | **bool** | True if the project is currently marked complete, false if not. | [optional] [readonly] 
**CompletedAt** | **DateTime?** | The time at which this project was completed, or null if the project is not completed. | [optional] [readonly] 
**CompletedBy** | [**UserCompact**](UserCompact.md) |  | [optional] 
**Followers** | [**List&lt;UserCompact&gt;**](UserCompact.md) | Array of users following this project. Followers are a subset of members who have opted in to receive \&quot;tasks added\&quot; notifications for a project. | [optional] [readonly] 
**Owner** | [**UserCompact**](UserCompact.md) | The current owner of the project, may be null. | [optional] 
**Team** | [**TeamCompact**](TeamCompact.md) |  | [optional] 
**Icon** | **string** | The icon for a project. | [optional] 
**PermalinkUrl** | **string** | A url that points directly to the object within Asana. | [optional] [readonly] 
**ProjectBrief** | [**ProjectBriefCompact**](ProjectBriefCompact.md) |  | [optional] 
**CreatedFromTemplate** | [**ProjectTemplateCompact**](ProjectTemplateCompact.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

