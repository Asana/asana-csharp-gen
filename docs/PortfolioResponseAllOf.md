
# asana.Model.PortfolioResponseAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 
**CreatedBy** | [**UserCompact**](UserCompact.md) |  | [optional] 
**CustomFieldSettings** | [**List&lt;CustomFieldSettingResponse&gt;**](CustomFieldSettingResponse.md) | Array of custom field settings applied to the portfolio. | [optional] 
**CurrentStatusUpdate** | [**StatusUpdateCompact**](StatusUpdateCompact.md) | The latest &#x60;status_update&#x60; posted to this portfolio. | [optional] 
**DueOn** | **DateTime?** | The localized day on which this portfolio is due. This takes a date with format YYYY-MM-DD. | [optional] 
**CustomFields** | [**List&lt;CustomFieldCompact&gt;**](CustomFieldCompact.md) | Array of Custom Fields. | [optional] 
**Members** | [**List&lt;UserCompact&gt;**](UserCompact.md) |  | [optional] [readonly] 
**Owner** | [**UserCompact**](UserCompact.md) |  | [optional] 
**StartOn** | **DateTime?** | The day on which work for this portfolio begins, or null if the portfolio has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format. *Note: &#x60;due_on&#x60; must be present in the request when setting or unsetting the &#x60;start_on&#x60; parameter. Additionally, &#x60;start_on&#x60; and &#x60;due_on&#x60; cannot be the same date.* | [optional] 
**Workspace** | [**WorkspaceCompact**](WorkspaceCompact.md) |  | [optional] 
**PermalinkUrl** | **string** | A url that points directly to the object within Asana. | [optional] [readonly] 
**Public** | **bool** | True if the portfolio is public to its workspace members. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

