
# asana.Model.StatusUpdateResponseAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Author** | [**UserCompact**](UserCompact.md) |  | [optional] 
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 
**CreatedBy** | [**UserCompact**](UserCompact.md) |  | [optional] 
**Hearted** | **bool** | *Deprecated - please use liked instead* True if the status is hearted by the authorized user, false if not. | [optional] [readonly] 
**Hearts** | [**List&lt;Like&gt;**](Like.md) | *Deprecated - please use likes instead* Array of likes for users who have hearted this status. | [optional] [readonly] 
**Liked** | **bool** | True if the status is liked by the authorized user, false if not. | [optional] 
**Likes** | [**List&lt;Like&gt;**](Like.md) | Array of likes for users who have liked this status. | [optional] [readonly] 
**ModifiedAt** | **DateTime** | The time at which this project status was last modified. *Note: This does not currently reflect any changes in associations such as comments that may have been added or removed from the status.* | [optional] [readonly] 
**NumHearts** | **int** | *Deprecated - please use likes instead* The number of users who have hearted this status. | [optional] [readonly] 
**NumLikes** | **int** | The number of users who have liked this status. | [optional] [readonly] 
**Parent** | [**ProjectCompact**](ProjectCompact.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

