
# asana.Model.EventResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**User** | [**EventResponseUser**](EventResponseUser.md) |  | [optional] 
**Resource** | [**EventResponseResource**](EventResponseResource.md) |  | [optional] 
**Type** | **string** | *Deprecated: Refer to the resource_type of the resource.* The type of the resource that generated the event. | [optional] [readonly] 
**Action** | **string** | The type of action taken on the **resource** that triggered the event.  This can be one of &#x60;changed&#x60;, &#x60;added&#x60;, &#x60;removed&#x60;, &#x60;deleted&#x60;, or &#x60;undeleted&#x60; depending on the nature of the event. | [optional] [readonly] 
**Parent** | [**EventResponseParent**](EventResponseParent.md) |  | [optional] 
**CreatedAt** | **DateTime** | The timestamp when the event occurred. | [optional] [readonly] 
**Change** | [**EventResponseChange**](EventResponseChange.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

