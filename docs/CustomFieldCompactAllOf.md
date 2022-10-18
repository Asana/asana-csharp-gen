
# asana.Model.CustomFieldCompactAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the custom field. | [optional] 
**ResourceSubtype** | **string** | The type of the custom field. Must be one of the given values.  | [optional] 
**Type** | **string** | *Deprecated: new integrations should prefer the resource_subtype field.* The type of the custom field. Must be one of the given values.  | [optional] [readonly] 
**EnumOptions** | [**List&lt;EnumOption&gt;**](EnumOption.md) | *Conditional*. Only relevant for custom fields of type &#x60;enum&#x60;. This array specifies the possible values which an &#x60;enum&#x60; custom field can adopt. To modify the enum options, refer to [working with enum options](/docs/create-an-enum-option). | [optional] 
**Enabled** | **bool** | *Conditional*. Determines if the custom field is enabled or not. | [optional] 
**DateValue** | [**CustomFieldCompactAllOfDateValue**](CustomFieldCompactAllOfDateValue.md) |  | [optional] 
**EnumValue** | [**EnumOption**](EnumOption.md) |  | [optional] 
**MultiEnumValues** | [**List&lt;EnumOption&gt;**](EnumOption.md) | *Conditional*. Only relevant for custom fields of type &#x60;multi_enum&#x60;. This object is the chosen values of a &#x60;multi_enum&#x60; custom field. | [optional] 
**NumberValue** | **decimal** | *Conditional*. This number is the value of a &#x60;number&#x60; custom field. | [optional] 
**TextValue** | **string** | *Conditional*. This string is the value of a &#x60;text&#x60; custom field. | [optional] 
**DisplayValue** | **string** | A string representation for the value of the custom field. Integrations that don&#39;t require the underlying type should use this field to read values. Using this field will future-proof an app against new custom field types. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

