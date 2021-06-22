using System;
using System.Collections.Generic;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Client
{
    public static class NotificationTopics
    {
        public static Dictionary<string, Type> Topics;

        static NotificationTopics()
        {
            Topics = new Dictionary<string, Type>
            { 
              {"v2.analytics.conversations.details.jobs.availability", typeof(ConversationDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification)},
              {"v2.analytics.flow.{id}.aggregates", typeof(StatEventFlowTopicStatsNotification)},
              {"v2.analytics.flowoutcome.{id}.aggregates", typeof(StatEventFlowOutcomeTopicStatsNotification)},
              {"v2.analytics.queues.{id}.observations", typeof(StatEventQueueTopicStatsNotification)},
              {"v2.analytics.users.details.jobs.availability", typeof(UserDetailsDatalakeAvailabilityTopicDataAvailabilityChangeNotification)},
              {"v2.analytics.users.{id}.aggregates", typeof(StatEventUserTopicStatsNotification)},
              {"v2.analytics.wrapup.{id}.aggregates", typeof(StatEventWrapUpCodeTopicStatsNotification)},
              {"v2.architect.dependencytracking.build", typeof(ArchitectDependencyTrackingBuildNotificationDependencyTrackingBuildNotification)},
              {"v2.architect.prompts.{id}", typeof(ArchitectPromptNotificationPromptNotification)},
              {"v2.architect.prompts.{id}.resources.{id}", typeof(ArchitectPromptResourceNotificationPromptResourceNotification)},
              {"v2.architect.systemprompts.{id}.resources.{id}", typeof(ArchitectSystemPromptResourceNotificationSystemPromptResourceNotification)},
              {"v2.audits.entitytype.{id}.entityid.{id}", typeof(AuditTopicAuditLogMessage)},
              {"v2.businessunits.{id}.workforcemanagement.intraday", typeof(WfmBuIntradayDataUpdateTopicBuIntradayNotification)},
              {"v2.contentmanagement.documents.{id}", typeof(ContentManagementSingleDocumentTopicDocumentDataV2)},
              {"v2.contentmanagement.workspaces.{id}.documents", typeof(ContentManagementWorkspaceDocumentsTopicDocumentDataV2)},
              {"v2.conversations.{id}.transcription", typeof(TranscriptionTopicTranscriptionMessage)},
              {"v2.flows.outcomes.{id}", typeof(ArchitectFlowOutcomeNotificationFlowOutcomeNotification)},
              {"v2.flows.{id}", typeof(ArchitectFlowNotificationFlowNotification)},
              {"v2.groups.{id}.greetings", typeof(GroupGreetingEventGreeting)},
              {"v2.managementunits.{id}.workforcemanagement.intraday", typeof(WfmIntradayDataUpdateTopicIntradayDataUpdate)},
              {"v2.outbound.attemptlimits.{id}", typeof(DialerAttemptLimitsConfigChangeAttemptLimits)},
              {"v2.outbound.callabletimesets.{id}", typeof(DialerCallabletimesetConfigChangeCallableTimeSet)},
              {"v2.outbound.campaignrules.{id}", typeof(DialerCampaignRuleConfigChangeCampaignRule)},
              {"v2.outbound.campaigns.{id}", typeof(DialerCampaignConfigChangeCampaign)},
              {"v2.outbound.campaigns.{id}.progress", typeof(DialerCampaignProgressEventCampaignProgress)},
              {"v2.outbound.campaigns.{id}.stats", typeof(StatEventCampaignTopicStatsNotification)},
              {"v2.outbound.contactlistfilters.{id}", typeof(DialerContactlistfilterConfigChangeContactListFilter)},
              {"v2.outbound.contactlists.{id}", typeof(DialerContactlistConfigChangeContactList)},
              {"v2.outbound.contactlists.{id}.importstatus", typeof(ContactlistImportStatusImportStatus)},
              {"v2.outbound.dnclists.{id}", typeof(DialerDnclistConfigChangeDncList)},
              {"v2.outbound.dnclists.{id}.importstatus", typeof(DnclistImportStatusImportStatus)},
              {"v2.outbound.messagingcampaigns.{id}", typeof(OutboundMessagingMessagingCampaignConfigChangeMessagingCampaign)},
              {"v2.outbound.messagingcampaigns.{id}.progress", typeof(OutboundMessagingMessagingCampaignProgressEventCampaignProgress)},
              {"v2.outbound.responsesets.{id}", typeof(DialerResponsesetConfigChangeResponseSet)},
              {"v2.outbound.rulesets.{id}", typeof(DialerRulesetConfigChangeRuleSet)},
              {"v2.outbound.schedules.campaigns.{id}", typeof(DialerCampaignScheduleConfigChangeCampaignSchedule)},
              {"v2.outbound.schedules.sequences.{id}", typeof(DialerSequenceScheduleConfigChangeSequenceSchedule)},
              {"v2.outbound.sequences.{id}", typeof(DialerSequenceConfigChangeCampaignSequence)},
              {"v2.outbound.settings", typeof(DialerOutboundSettingsConfigChangeOutboundSettings)},
              {"v2.outbound.wrapupcodemappings.{id}", typeof(DialerWrapupcodemappingConfigChangeWrapUpCodeMapping)},
              {"v2.quality.evaluations", typeof(EvaluationQualityV2TopicEvaluationV2)},
              {"v2.routing.queues.{id}.conversations", typeof(QueueConversationEventTopicConversation)},
              {"v2.routing.queues.{id}.conversations.callbacks", typeof(QueueConversationCallbackEventTopicCallbackConversation)},
              {"v2.routing.queues.{id}.conversations.calls", typeof(QueueConversationCallEventTopicCallConversation)},
              {"v2.routing.queues.{id}.conversations.chats", typeof(QueueConversationChatEventTopicChatConversation)},
              {"v2.routing.queues.{id}.conversations.cobrowseSessions", typeof(QueueConversationCobrowseEventTopicCobrowseConversation)},
              {"v2.routing.queues.{id}.conversations.emails", typeof(QueueConversationEmailEventTopicEmailConversation)},
              {"v2.routing.queues.{id}.conversations.messages", typeof(QueueConversationMessageEventTopicMessageConversation)},
              {"v2.routing.queues.{id}.conversations.screenshares", typeof(QueueConversationScreenShareEventTopicScreenShareConversation)},
              {"v2.routing.queues.{id}.conversations.socialexpressions", typeof(QueueConversationSocialExpressionEventTopicConversation)},
              {"v2.routing.queues.{id}.conversations.videos", typeof(QueueConversationVideoEventTopicConversation)},
              {"v2.routing.queues.{id}.users", typeof(QueueUserEventTopicQueueMember)},
              {"v2.speechandtextanalytics.programs.publishjobs.{id}", typeof(PublishProgramPublishJob)},
              {"v2.speechandtextanalytics.topics.publishjobs.{id}", typeof(PublishTopicPublishJob)},
              {"v2.system.no_longer_subscribed.{id}", typeof(SystemMessageSystemMessage)},
              {"v2.system.socket_closing", typeof(SystemMessageSystemMessage)},
              {"v2.system.token_revoked.{id}", typeof(SystemMessageSystemMessage)},
              {"v2.system.{id}.{id}", typeof(SystemMessageSystemMessage)},
              {"v2.telephony.providers.edges.phones.{id}", typeof(PhoneChangeTopicPhone)},
              {"v2.telephony.providers.edges.trunks.{id}", typeof(TrunkInstanceTopicTrunk)},
              {"v2.telephony.providers.edges.trunks.{id}.metrics", typeof(TrunkMetricsTopicTrunkMetrics)},
              {"v2.telephony.providers.edges.{id}", typeof(EdgeChangeTopicEdge)},
              {"v2.telephony.providers.edges.{id}.logicalinterfaces", typeof(EdgeLogicalInterfacesChangeTopicDomainLogicalInterfaceChange)},
              {"v2.telephony.providers.edges.{id}.metrics", typeof(EdgeMetricsTopicEdgeMetrics)},
              {"v2.telephony.providers.edges.{id}.softwareupdate", typeof(EdgeSoftwareUpdateTopicDomainEdgeSoftwareUpdate)},
              {"v2.users.{id}.activity", typeof(AgentActivityChangedTopicAgentActivity)},
              {"v2.users.{id}.alerting.heartbeat.alerts", typeof(KlaxonHeartBeatAlertsTopicHeartBeatAlert)},
              {"v2.users.{id}.alerting.heartbeat.rules", typeof(KlaxonHeartBeatRulesTopicHeartBeatRule)},
              {"v2.users.{id}.alerting.interactionstats.alerts", typeof(KlaxonInteractionStatsAlertsTopicInteractionStatAlert)},
              {"v2.users.{id}.alerting.interactionstats.rules", typeof(KlaxonInteractionStatsRulesTopicInteractionStatRule)},
              {"v2.users.{id}.analytics.reporting.exports", typeof(ReportingDataExportTopicDataExportNotification)},
              {"v2.users.{id}.badges.chats", typeof(ChatBadgeTopicChatBadge)},
              {"v2.users.{id}.callforwarding", typeof(CallForwardingEventCallForwarding)},
              {"v2.users.{id}.conversations", typeof(ConversationEventTopicConversation)},
              {"v2.users.{id}.conversations.callbacks", typeof(ConversationCallbackEventTopicCallbackConversation)},
              {"v2.users.{id}.conversations.calls", typeof(ConversationCallEventTopicCallConversation)},
              {"v2.users.{id}.conversations.chats", typeof(ConversationChatEventTopicChatConversation)},
              {"v2.users.{id}.conversations.cobrowseSessions", typeof(ConversationCobrowseEventTopicCobrowseConversation)},
              {"v2.users.{id}.conversations.emails", typeof(ConversationEmailEventTopicEmailConversation)},
              {"v2.users.{id}.conversations.messages", typeof(ConversationMessageEventTopicMessageConversation)},
              {"v2.users.{id}.conversations.screenshares", typeof(ConversationScreenShareEventTopicScreenShareConversation)},
              {"v2.users.{id}.conversations.socialexpressions", typeof(ConversationSocialExpressionEventTopicSocialConversation)},
              {"v2.users.{id}.conversations.videos", typeof(ConversationVideoEventTopicVideoConversation)},
              {"v2.users.{id}.conversations.{id}.recordings", typeof(RecordingEventRecording)},
              {"v2.users.{id}.conversations.{id}.recordings.{id}", typeof(RecordingTranscodeCompleteTopicRecording)},
              {"v2.users.{id}.conversationsummary", typeof(UserConversationsEventUserConversationSummary)},
              {"v2.users.{id}.fax.documents", typeof(FaxTopicFaxDataV2)},
              {"v2.users.{id}.geolocation", typeof(GeolocationEventGeolocation)},
              {"v2.users.{id}.greetings", typeof(UserGreetingEventGreeting)},
              {"v2.users.{id}.outbound.contactlists.{id}.export", typeof(ContactlistDownloadReadyExportUri)},
              {"v2.users.{id}.outbound.dnclists.{id}.export", typeof(DnclistDownloadReadyExportUri)},
              {"v2.users.{id}.outofoffice", typeof(OutOfOfficeEventOutOfOffice)},
              {"v2.users.{id}.presence", typeof(PresenceEventUserPresence)},
              {"v2.users.{id}.recordings", typeof(RecordingArchiveRestoreTopicRecording)},
              {"v2.users.{id}.routingStatus", typeof(UserRoutingStatusUserRoutingStatus)},
              {"v2.users.{id}.station", typeof(UserStationChangeTopicUserStations)},
              {"v2.users.{id}.tokens", typeof(UserTokensTopicTokenNotification)},
              {"v2.users.{id}.userrecordings", typeof(AdhocRecordingTopicRecordingDataV2)},
              {"v2.users.{id}.voicemail.messages", typeof(VoicemailMessagesTopicVoicemailMessage)},
              {"v2.users.{id}.wem.coaching.appointment", typeof(WemCoachingAppointmentTopicCoachingAppointmentNotification)},
              {"v2.users.{id}.wem.learning.assignment", typeof(WemLearningAssignmentTopicLearningAssignmentNotification)},
              {"v2.users.{id}.workforcemanagement.adherence", typeof(WfmUserScheduleAdherenceUpdatedTopicUserScheduleAdherenceUpdate)},
              {"v2.users.{id}.workforcemanagement.historicaladherencequery", typeof(WfmHistoricalAdherenceCalculationsCompleteTopicWfmHistoricalAdherenceCalculationsCompleteNotice)},
              {"v2.users.{id}.workforcemanagement.notifications", typeof(WfmUserNotificationTopicWfmUserNotification)},
              {"v2.users.{id}.workforcemanagement.schedules", typeof(WfmAgentScheduleUpdateTopicWfmAgentScheduleUpdateNotification)},
              {"v2.users.{id}.workforcemanagement.timeoffrequests", typeof(WfmTimeOffRequestUpdateTopicTimeOffRequestUpdate)},
              {"v2.webdeployments.configurations.{id}", typeof(WebDeploymentsConfigTopicWebMessagingConfigChangeEventBody)},
              {"v2.webdeployments.deployments.{id}", typeof(WebDeploymentsDeploymentTopicWebMessagingDeploymentChangeEventBody)},
              {"v2.wem.learning.assignments.modules.{id}", typeof(WemLearningAssignmentRuleRunTopicLearningAssignmentRuleRunNotification)},
              {"v2.workforcemanagement.agents", typeof(WfmMoveAgentsCompleteTopicWfmMoveAgentsComplete)},
              {"v2.workforcemanagement.businessunits.{id}.schedules", typeof(WfmBuScheduleTopicBuScheduleNotification)},
              {"v2.workforcemanagement.businessunits.{id}.scheduling.runs", typeof(WfmBuScheduleRunTopicBuSchedulingRunProgressNotification)},
              {"v2.workforcemanagement.businessunits.{id}.shorttermforecasts", typeof(WfmBuShortTermForecastUpdateCompleteTopicBuShortTermForecastNotification)},
              {"v2.workforcemanagement.businessunits.{id}.shorttermforecasts.copy", typeof(WfmBuShortTermForecastCopyCompleteTopicBuShortTermForecastNotification)},
              {"v2.workforcemanagement.businessunits.{id}.shorttermforecasts.generate", typeof(WfmBuShortTermForecastGenerateProgressTopicGenerateBuShortTermForecastProgressNotification)},
              {"v2.workforcemanagement.businessunits.{id}.shorttermforecasts.import", typeof(WfmBuShortTermForecastImportCompleteTopicBuShortTermForecastNotification)},
              {"v2.workforcemanagement.historicaldata.deletejob", typeof(WfmHistoricalDataUploadPurgeRequestStatusTopicHistoricalDataUploadPurgeRequestUpdate)},
              {"v2.workforcemanagement.historicaldata.status", typeof(WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate)},
              {"v2.workforcemanagement.managementunits.{id}", typeof(WfmMoveManagementUnitTopicMoveManagementUnitNotification)},
              {"v2.workforcemanagement.managementunits.{id}.adherence", typeof(WfmUserScheduleAdherenceUpdatedMuTopicUserScheduleAdherenceUpdate)},
              {"v2.workforcemanagement.managementunits.{id}.agents.sync", typeof(WfmUpdateAgentDetailsTopicWfmUpdateAgentDetailsComplete)},
              {"v2.workforcemanagement.managementunits.{id}.schedules", typeof(WfmScheduleTopicWfmScheduleNotification)},
              {"v2.workforcemanagement.managementunits.{id}.shifttrades.state.bulk", typeof(WfmBulkShiftTradeStateUpdateNotificationTopicBulkShiftTradeStateUpdateNotification)},
              {"v2.workforcemanagement.teams.{id}.adherence", typeof(WfmUserScheduleAdherenceUpdatedTeamTopicUserScheduleAdherenceUpdate)},
              {"v2.workforcemanagement.users.{id}.schedules.query", typeof(WfmBuScheduleQueryResultTopicBuScheduleSearchResultNotification)},
              {"v2.workforcemanagement.users.{id}.schedules.search", typeof(WfmBuScheduleSearchResultTopicBuScheduleSearchResultNotification)},
            };
        }
    }
}