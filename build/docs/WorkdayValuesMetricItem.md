---
title: WorkdayValuesMetricItem
---
## ININ.PureCloudApi.Model.WorkdayValuesMetricItem

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Metric** | [**AddressableEntityRef**](AddressableEntityRef.html) | Gamification metric for the average and the trend | [optional] |
| **MetricDefinition** | [**DomainEntityRef**](DomainEntityRef.html) | Gamification metric definition for the average and the trend | [optional] |
| **Average** | **double?** | The average value of the metric | [optional] |
| **UnitType** | **string** | The unit type of the metric value | [optional] |
| **Trend** | [**List&lt;WorkdayValuesTrendItem&gt;**](WorkdayValuesTrendItem.html) | The metric value trend | [optional] |
{: class="table table-striped"}


