
# asana.Model.WebhookResponseAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 
**LastFailureAt** | **DateTime** | The timestamp when the webhook last received an error when sending an event to the target. | [optional] [readonly] 
**LastFailureContent** | **string** | The contents of the last error response sent to the webhook when attempting to deliver events to the target. | [optional] [readonly] 
**LastSuccessAt** | **DateTime** | The timestamp when the webhook last successfully sent an event to the target. | [optional] [readonly] 
**Filters** | [**List&lt;WebhookFilter&gt;**](WebhookFilter.md) | Whitelist of filters to apply to events from this webhook. If a webhook event passes any of the filters the event will be delivered; otherwise no event will be sent to the receiving server. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

