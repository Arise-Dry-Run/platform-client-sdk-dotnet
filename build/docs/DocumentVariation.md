---
title: DocumentVariation
---
## ININ.PureCloudApi.Model.DocumentVariation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the variation. | [optional] |
| **Body** | [**DocumentBody**](DocumentBody.html) | The content for the variation. | [optional] |
| **DateCreated** | **DateTime?** | The creation date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The last modification date-time for the document variation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DocumentVersion** | [**AddressableEntityRef**](AddressableEntityRef.html) | The version of the document. | [optional] |
| **Contexts** | [**List&lt;DocumentVariationContext&gt;**](DocumentVariationContext.html) | The context values associated with the variation. | |
| **Document** | [**KnowledgeDocumentReference**](KnowledgeDocumentReference.html) | The reference to document to which the variation is associated. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


