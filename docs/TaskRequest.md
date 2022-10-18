
# asana.Model.TaskRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | Name of the task. This is generally a short sentence fragment that fits on a line in the UI for maximum readability. However, it can be longer. | [optional] 
**ResourceSubtype** | **string** | The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The resource_subtype &#x60;milestone&#x60; represent a single moment in time. This means tasks with this subtype cannot have a start_date. | [optional] 
**ApprovalStatus** | **string** | *Conditional* Reflects the approval status of this task. This field is kept in sync with &#x60;completed&#x60;, meaning &#x60;pending&#x60; translates to false while &#x60;approved&#x60;, &#x60;rejected&#x60;, and &#x60;changes_requested&#x60; translate to true. If you set completed to true, this field will be set to &#x60;approved&#x60;. | [optional] 
**AssigneeStatus** | **string** | *Deprecated* Scheduling status of this task for the user it is assigned to. This field can only be set if the assignee is non-null. Setting this field to \&quot;inbox\&quot; or \&quot;upcoming\&quot; inserts it at the top of the section, while the other options will insert at the bottom. | [optional] 
**Completed** | **bool** | True if the task is currently marked complete, false if not. | [optional] 
**CompletedAt** | **DateTime?** | The time at which this task was completed, or null if the task is incomplete. | [optional] [readonly] 
**CompletedBy** | [**UserCompact**](UserCompact.md) |  | [optional] 
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 
**Dependencies** | [**List&lt;AsanaResource&gt;**](AsanaResource.md) | [Opt In](/docs/input-output-options). Array of resources referencing tasks that this task depends on. The objects contain only the gid of the dependency. | [optional] [readonly] 
**Dependents** | [**List&lt;AsanaResource&gt;**](AsanaResource.md) | [Opt In](/docs/input-output-options). Array of resources referencing tasks that depend on this task. The objects contain only the ID of the dependent. | [optional] [readonly] 
**DueAt** | **DateTime?** | The UTC date and time on which this task is due, or null if the task has no due time. This takes an ISO 8601 date string in UTC and should not be used together with &#x60;due_on&#x60;. | [optional] 
**DueOn** | **DateTime?** | The localized date on which this task is due, or null if the task has no due date. This takes a date with &#x60;YYYY-MM-DD&#x60; format and should not be used together with &#x60;due_at&#x60;. | [optional] 
**External** | [**TaskBaseAllOfExternal**](TaskBaseAllOfExternal.md) |  | [optional] 
**HtmlNotes** | **string** | [Opt In](/docs/input-output-options). The notes of the text with formatting as HTML. | [optional] 
**Hearted** | **bool** | *Deprecated - please use liked instead* True if the task is hearted by the authorized user, false if not. | [optional] [readonly] 
**Hearts** | [**List&lt;Like&gt;**](Like.md) | *Deprecated - please use likes instead* Array of likes for users who have hearted this task. | [optional] [readonly] 
**IsRenderedAsSeparator** | **bool** | [Opt In](/docs/input-output-options). In some contexts tasks can be rendered as a visual separator; for instance, subtasks can appear similar to [sections](/docs/asana-sections) without being true &#x60;section&#x60; objects. If a &#x60;task&#x60; object is rendered this way in any context it will have the property &#x60;is_rendered_as_separator&#x60; set to &#x60;true&#x60;. | [optional] [readonly] 
**Liked** | **bool** | True if the task is liked by the authorized user, false if not. | [optional] 
**Likes** | [**List&lt;Like&gt;**](Like.md) | Array of likes for users who have liked this task. | [optional] [readonly] 
**Memberships** | [**List&lt;TaskBaseAllOfMemberships&gt;**](TaskBaseAllOfMemberships.md) | *Create-only*. Array of projects this task is associated with and the section it is in. At task creation time, this array can be used to add the task to specific sections. After task creation, these associations can be modified using the &#x60;addProject&#x60; and &#x60;removeProject&#x60; endpoints. Note that over time, more types of memberships may be added to this property. | [optional] [readonly] 
**ModifiedAt** | **DateTime** | The time at which this task was last modified.  *Note: This does not currently reflect any changes in associations such as projects or comments that may have been added or removed from the task.* | [optional] [readonly] 
**Notes** | **string** | Free-form textual information associated with the task (i.e. its description). | [optional] 
**NumHearts** | **int** | *Deprecated - please use likes instead* The number of users who have hearted this task. | [optional] [readonly] 
**NumLikes** | **int** | The number of users who have liked this task. | [optional] [readonly] 
**NumSubtasks** | **int** | [Opt In](/docs/input-output-options). The number of subtasks on this task.  | [optional] [readonly] 
**StartAt** | **DateTime?** | Date and time on which work begins for the task, or null if the task has no start time. This takes an ISO 8601 date string in UTC and should not be used together with &#x60;start_on&#x60;. *Note: &#x60;due_at&#x60; must be present in the request when setting or unsetting the &#x60;start_at&#x60; parameter.* | [optional] 
**StartOn** | **DateTime?** | The day on which work begins for the task , or null if the task has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format and should not be used together with &#x60;start_at&#x60;. *Note: &#x60;due_on&#x60; or &#x60;due_at&#x60; must be present in the request when setting or unsetting the &#x60;start_on&#x60; parameter.* | [optional] 
**Assignee** | **string** | Gid of a user. | [optional] 
**AssigneeSection** | **string** | The *assignee section* is a subdivision of a project that groups tasks together in the assignee&#39;s \&quot;My Tasks\&quot; list. It can either be a header above a list of tasks in a list view or a column in a board view of \&quot;My Tasks.\&quot; The &#x60;assignee_section&#x60; property will be returned in the response only if the request was sent by the user who is the assignee of the task. Note that you can only write to &#x60;assignee_section&#x60; with the gid of an existing section visible in the user&#39;s \&quot;My Tasks\&quot; list. | [optional] 
**CustomFields** | **Dictionary&lt;string, string&gt;** | An object where each key is a Custom Field GID and each value is an enum GID, string, number, object, or array. | [optional] 
**Followers** | **List&lt;string&gt;** | *Create-Only* An array of strings identifying users. These can either be the string \&quot;me\&quot;, an email, or the gid of a user. In order to change followers on an existing task use &#x60;addFollowers&#x60; and &#x60;removeFollowers&#x60;. | [optional] 
**Parent** | **string** | Gid of a task. | [optional] 
**Projects** | **List&lt;string&gt;** | *Create-Only* Array of project gids. In order to change projects on an existing task use &#x60;addProject&#x60; and &#x60;removeProject&#x60;. | [optional] 
**Tags** | **List&lt;string&gt;** | *Create-Only* Array of tag gids. In order to change tags on an existing task use &#x60;addTag&#x60; and &#x60;removeTag&#x60;. | [optional] 
**Workspace** | **string** | Gid of a workspace. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

