
# asana.Model.CustomFieldBaseAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | [Opt In](/docs/input-output-options). The description of the custom field. | [optional] 
**EnumOptions** | [**List&lt;EnumOption&gt;**](EnumOption.md) | *Conditional*. Only relevant for custom fields of type &#x60;enum&#x60;. This array specifies the possible values which an &#x60;enum&#x60; custom field can adopt. To modify the enum options, refer to [working with enum options](/docs/create-an-enum-option). | [optional] 
**Precision** | **int** | Only relevant for custom fields of type ‘Number’. This field dictates the number of places after the decimal to round to, i.e. 0 is integer values, 1 rounds to the nearest tenth, and so on. Must be between 0 and 6, inclusive. For percentage format, this may be unintuitive, as a value of 0.25 has a precision of 0, while a value of 0.251 has a precision of 1. This is due to 0.25 being displayed as 25%. The identifier format will always have a precision of 0. | [optional] 
**Format** | **string** | The format of this custom field. | [optional] 
**CurrencyCode** | **string** | ISO 4217 currency code to format this custom field. This will be null if the &#x60;format&#x60; is not &#x60;currency&#x60;. | [optional] 
**CustomLabel** | **string** | This is the string that appears next to the custom field value. This will be null if the &#x60;format&#x60; is not &#x60;custom&#x60;. | [optional] 
**CustomLabelPosition** | **string** | Only relevant for custom fields with &#x60;custom&#x60; format. This depicts where to place the custom label. This will be null if the &#x60;format&#x60; is not &#x60;custom&#x60;. | [optional] 
**IsGlobalToWorkspace** | **bool** | This flag describes whether this custom field is available to every container in the workspace. Before project-specific custom fields, this field was always true. | [optional] [readonly] 
**HasNotificationsEnabled** | **bool** | *Conditional*. This flag describes whether a follower of a task with this field should receive inbox notifications from changes to this field. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

