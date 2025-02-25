---
title: OpenIntegrationRequest
---
## ININ.PureCloudApi.Model.OpenIntegrationRequest

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** | The name of the Open messaging integration. | |
| **SupportedContent** | [**SupportedContentReference**](SupportedContentReference.html) | Defines the SupportedContent profile configured for an integration | [optional] |
| **MessagingSetting** | [**MessagingSettingReference**](MessagingSettingReference.html) |  | [optional] |
| **OutboundNotificationWebhookUrl** | **string** | The outbound notification webhook URL for the Open messaging integration. | |
| **OutboundNotificationWebhookSignatureSecretToken** | **string** | The outbound notification webhook signature secret token. This token must be longer than 15 characters. | |
| **WebhookHeaders** | **Dictionary&lt;string, string&gt;** | The user specified headers for the Open messaging integration. | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


