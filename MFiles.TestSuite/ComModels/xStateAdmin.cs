using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;

namespace VaultMockObjects.ComModels
{
    public class xStateAdmin
    {
        public bool ActionAssignToUser { get; set; }
        public xActionCreateAssignment ActionAssignToUserDefinition { get; set; }
        public bool ActionConvertToPDF { get; set; }
        public xActionConvertToPDF ActionConvertToPDFDefinition { get; set; }
        public bool ActionCreateSeparateAssignment { get; set; }
        public xActionCreateAssignment ActionCreateSeparateAssignmentDefinition { get; set; }
        public bool ActionDelete { get; set; }
        public bool ActionMarkForArchiving { get; set; }
        public bool ActionRunVBScript { get; set; }
        public string ActionRunVBScriptDefinition { get; set; }
        public bool ActionSendNotification { get; set; }
        public xActionSendNotification ActionSendNotificationDefinition { get; set; }
        public bool ActionSetPermissions { get; set; }
        public xActionSetPermissions ActionSetPermissionsDetailedDefinition { get; set; }
        public bool ActionSetProperties { get; set; }
        public xActionSetProperties ActionSetPropertiesDefinition { get; set; }
        public string AutomaticStateTransitionAllowedByVBScript { get; set; }
        public xSearchCondition[] AutomaticStateTransitionCriteria { get; set; }
        public int AutomaticStateTransitionInDays { get; set; }
        public int AutomaticStateTransitionMode { get; set; }
        public int AutomaticStateTransitionNextState { get; set; }
        public bool CheckInOutPermissions { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public xAccessControlList InOutPermissions { get; set; }
        public string Name { get; set; }
        public xStateConditions Postconditions { get; set; }
        public xStateConditions Preconditions { get; set; }
        public bool RestrictTransitions { get; set; }
        public string[] SemanticAliases { get; set; }
        public bool TransitionsRequireEditAccessToObject { get; set; }

        public xStateAdmin() { }

        public xStateAdmin(StateAdmin sa)
        {
            this.ActionAssignToUser = sa.ActionAssignToUser;
            this.ActionAssignToUserDefinition = new xActionCreateAssignment(sa.ActionAssignToUserDefinition);
            this.ActionConvertToPDF = sa.ActionConvertToPDF;
            this.ActionConvertToPDFDefinition = new xActionConvertToPDF(sa.ActionConvertToPDFDefinition);
            this.ActionCreateSeparateAssignment = sa.ActionCreateSeparateAssignment;
            this.ActionCreateSeparateAssignmentDefinition = new xActionCreateAssignment(sa.ActionCreateSeparateAssignmentDefinition);
            this.ActionDelete = sa.ActionDelete;
            this.ActionMarkForArchiving = sa.ActionMarkForArchiving;
            this.ActionRunVBScript = sa.ActionRunVBScript;
            this.ActionRunVBScriptDefinition = sa.ActionRunVBScriptDefinition;
            this.ActionSendNotification = sa.ActionSendNotification;
            this.ActionSendNotificationDefinition = new xActionSendNotification(sa.ActionSendNotificationDefinition);
            this.ActionSetPermissions = sa.ActionSetPermissions;
            this.ActionSetPermissionsDetailedDefinition = new xActionSetPermissions(sa.ActionSetPermissionsDetailedDefinition);
            this.ActionSetProperties = sa.ActionSetProperties;
            this.ActionSetPropertiesDefinition = new xActionSetProperties(sa.ActionSetPropertiesDefinition);
            this.AutomaticStateTransitionAllowedByVBScript = sa.AutomaticStateTransitionAllowedByVBScript;
            this.AutomaticStateTransitionCriteria = (from SearchCondition searchCondition in sa.AutomaticStateTransitionCriteria select new xSearchCondition(searchCondition)).ToArray();
            this.AutomaticStateTransitionInDays = sa.AutomaticStateTransitionInDays;
            this.AutomaticStateTransitionMode = (int) sa.AutomaticStateTransitionMode;
            this.AutomaticStateTransitionNextState = sa.AutomaticStateTransitionNextState;
            this.CheckInOutPermissions = sa.CheckInOutPermissions;
            this.Description = sa.Description;
            this.ID = sa.ID;
            this.InOutPermissions = new xAccessControlList(sa.InOutPermissions);
            this.Name = sa.Name;
            this.Postconditions = new xStateConditions(sa.Postconditions);
            this.Preconditions = new xStateConditions(sa.Preconditions);
            this.RestrictTransitions = sa.RestrictTransitions;
            this.SemanticAliases = sa.SemanticAliases.Value.Split(';');
            this.TransitionsRequireEditAccessToObject = sa.TransitionsRequireEditAccessToObject;
        }
    }
}
