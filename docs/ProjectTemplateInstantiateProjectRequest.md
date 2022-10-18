
# asana.Model.ProjectTemplateInstantiateProjectRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the new project. | 
**Team** | **string** | *Conditional*. Sets the team of the new project. If the project template exists in an _organization_, you must specify a value for &#x60;team&#x60; and not &#x60;workspace&#x60;. | [optional] 
**Workspace** | **string** | *Conditional*. Sets the workspace of the new project. If the project template exists in a _workspace_, you must specify a value for &#x60;workspace&#x60; and not &#x60;team&#x60;. | [optional] 
**Public** | **bool** | Sets the project to public to its team. | 
**IsStrict** | **bool** | *Optional*. If set to &#x60;true&#x60;, the endpoint returns an \&quot;Unprocessable Entity\&quot; error if you fail to provide a calendar date value for any date variable. If set to &#x60;false&#x60;, a default date is used for each unfulfilled date variable (e.g., the current date is used as the Start Date of a project). | [optional] 
**RequestedDates** | [**List&lt;DateVariableRequest&gt;**](DateVariableRequest.md) | Array of mappings of date variables to calendar dates. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

