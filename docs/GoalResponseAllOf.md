
# asana.Model.GoalResponseAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Likes** | [**List&lt;Like&gt;**](Like.md) | Array of likes for users who have liked this goal. | [optional] [readonly] 
**NumLikes** | **int** | The number of users who have liked this goal. | [optional] [readonly] 
**Team** | [**TeamCompact**](TeamCompact.md) | *Conditional*. This property is only present when the &#x60;workspace&#x60; provided is an organization. | [optional] 
**Workspace** | [**WorkspaceCompact**](WorkspaceCompact.md) |  | [optional] 
**Followers** | [**List&lt;UserCompact&gt;**](UserCompact.md) | Array of users who are members of this goal. | [optional] 
**TimePeriod** | [**TimePeriodCompact**](TimePeriodCompact.md) |  | [optional] 
**Metric** | [**GoalMetricBase**](GoalMetricBase.md) |  | [optional] 
**Owner** | [**UserCompact**](UserCompact.md) |  | [optional] 
**CurrentStatusUpdate** | [**StatusUpdateCompact**](StatusUpdateCompact.md) | The latest &#x60;status_update&#x60; posted to this goal. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

