using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MFilesAPI;
using VaultMockObjects.ComModels;

namespace VaultMockObjects.MockObjectModels
{
    public class TestStateAdmin : StateAdmin
    {
        public TestStateAdmin() { }

        public TestStateAdmin(xStateAdmin sa)
        {
            this.ActionAssignToUser = sa.ActionAssignToUser;
            this.ActionAssignToUserDefinition = new TestActionCreateAssignment(sa.ActionAssignToUserDefinition);
            this.ActionConvertToPDF = sa.ActionConvertToPDF;
            this.ActionConvertToPDFDefinition = new TestActionConvertToPDF(sa.ActionConvertToPDFDefinition);
            this.ActionCreateSeparateAssignment = sa.ActionCreateSeparateAssignment;
            this.ActionCreateSeparateAssignmentDefinition = new TestActionCreateAssignment(sa.ActionCreateSeparateAssignmentDefinition);
            this.ActionDelete = sa.ActionDelete;
            this.ActionMarkForArchiving = sa.ActionMarkForArchiving;
            this.ActionRunVBScript = sa.ActionRunVBScript;
            this.ActionRunVBScriptDefinition = sa.ActionRunVBScriptDefinition;
            this.ActionSendNotification = sa.ActionSendNotification;
            this.ActionSendNotificationDefinition = new TestActionSendNotification(sa.ActionSendNotificationDefinition);
            this.ActionSetPermissions = sa.ActionSetPermissions;
            this.ActionSetPermissionsDetailedDefinition = new TestActionSetPermissions(sa.ActionSetPermissionsDetailedDefinition);
            this.ActionSetProperties = sa.ActionSetProperties;
            this.ActionSetPropertiesDefinition = new TestActionSetProperties(sa.ActionSetPropertiesDefinition);
            this.AutomaticStateTransitionAllowedByVBScript = sa.AutomaticStateTransitionAllowedByVBScript;
            this.AutomaticStateTransitionCriteria = new SearchConditions();
            foreach (xSearchCondition sc in sa.AutomaticStateTransitionCriteria)
            {
                this.AutomaticStateTransitionCriteria.Add(-1, new TestSearchCondition(sc));
            }
            this.AutomaticStateTransitionInDays = sa.AutomaticStateTransitionInDays;
            this.AutomaticStateTransitionMode = (MFAutoStateTransitionMode)sa.AutomaticStateTransitionMode;
            this.AutomaticStateTransitionNextState = sa.AutomaticStateTransitionNextState;
            this.CheckInOutPermissions = sa.CheckInOutPermissions;
            this.Description = sa.Description;
            this.ID = sa.ID;
            this.InOutPermissions = new TestAccessControlList(sa.InOutPermissions);
            this.Name = sa.Name;
            this.Postconditions = new TestStateConditions(sa.Postconditions);
            this.Preconditions = new TestStateConditions(sa.Preconditions);
            this.RestrictTransitions = sa.RestrictTransitions;
            this.SemanticAliases = new SemanticAliases{Value = string.Join(";",sa.SemanticAliases)};
            this.TransitionsRequireEditAccessToObject = sa.TransitionsRequireEditAccessToObject;
        }

        public bool ActionAssignToUser { get; set; }

        public ActionCreateAssignment ActionAssignToUserDefinition { get; set; }

        public bool ActionConvertToPDF { get; set; }

        public ActionConvertToPDF ActionConvertToPDFDefinition { get; set; }

        public bool ActionCreateSeparateAssignment { get; set; }

        public ActionCreateAssignment ActionCreateSeparateAssignmentDefinition { get; set; }

        public bool ActionDelete { get; set; }

        public bool ActionMarkForArchiving { get; set; }

        public bool ActionRunVBScript { get; set; }

        public string ActionRunVBScriptDefinition { get; set; }

        public bool ActionSendNotification { get; set; }

        public ActionSendNotification ActionSendNotificationDefinition { get; set; }

        public bool ActionSetPermissions { get; set; }

        public AccessControlList ActionSetPermissionsDefinition { get; set; }

        public ActionSetPermissions ActionSetPermissionsDetailedDefinition { get; set; }

        public bool ActionSetProperties { get; set; }

        public ActionSetProperties ActionSetPropertiesDefinition { get; set; }

        public string AutomaticStateTransitionAllowedByVBScript { get; set; }

        public SearchConditions AutomaticStateTransitionCriteria { get; set; }

        public int AutomaticStateTransitionInDays { get; set; }

        public MFAutoStateTransitionMode AutomaticStateTransitionMode { get; set; }

        public int AutomaticStateTransitionNextState { get; set; }

        public bool CheckInOutPermissions { get; set; }

        public StateAdmin Clone()
        {
            TestStateAdmin sa = new TestStateAdmin
            {
                ActionAssignToUser = this.ActionAssignToUser,
                ActionAssignToUserDefinition = this.ActionAssignToUserDefinition.Clone(),
                ActionConvertToPDF = this.ActionConvertToPDF,
                ActionConvertToPDFDefinition = this.ActionConvertToPDFDefinition.Clone(),
                ActionCreateSeparateAssignment = this.ActionCreateSeparateAssignment,
                ActionCreateSeparateAssignmentDefinition = this.ActionCreateSeparateAssignmentDefinition.Clone(),
                ActionDelete = this.ActionDelete,
                ActionMarkForArchiving = this.ActionMarkForArchiving,
                ActionRunVBScript = this.ActionRunVBScript,
                ActionRunVBScriptDefinition = this.ActionRunVBScriptDefinition,
                ActionSendNotification = this.ActionSendNotification,
                ActionSendNotificationDefinition = this.ActionSendNotificationDefinition.Clone(),
                ActionSetPermissions = this.ActionSetPermissions,
                ActionSetPermissionsDetailedDefinition = this.ActionSetPermissionsDetailedDefinition.Clone(),
                ActionSetProperties = this.ActionSetProperties,
                ActionSetPropertiesDefinition = this.ActionSetPropertiesDefinition.Clone(),
                AutomaticStateTransitionAllowedByVBScript = this.AutomaticStateTransitionAllowedByVBScript,
                AutomaticStateTransitionCriteria = new SearchConditions()
            };
            for (int i = 1; i <= this.AutomaticStateTransitionCriteria.Count; ++i)
            {
                SearchCondition sc = this.AutomaticStateTransitionCriteria[i];
                sa.AutomaticStateTransitionCriteria.Add(-1, sc.Clone());
            }
            sa.AutomaticStateTransitionInDays = this.AutomaticStateTransitionInDays;
            sa.AutomaticStateTransitionMode = this.AutomaticStateTransitionMode;
            sa.AutomaticStateTransitionNextState = this.AutomaticStateTransitionNextState;
            sa.CheckInOutPermissions = this.CheckInOutPermissions;
            sa.Description = this.Description;
            sa.ID = this.ID;
            sa.InOutPermissions = this.InOutPermissions.Clone();
            sa.Name = this.Name;
            sa.Postconditions = this.Postconditions.Clone();
            sa.Preconditions = this.Preconditions.Clone();
            sa.RestrictTransitions = this.RestrictTransitions;
            sa.SemanticAliases = new SemanticAliases { Value = this.SemanticAliases.Value };
            sa.TransitionsRequireEditAccessToObject = this.TransitionsRequireEditAccessToObject;
            return sa;
        }

        public string Description { get; set; }

        public int ID { get; set; }

        public AccessControlList InOutPermissions { get; set; }

        public string Name { get; set; }

        public StateConditions Postconditions { get; set; }

        public StateConditions Preconditions { get; set; }

        public bool RestrictTransitions { get; set; }

        public SemanticAliases SemanticAliases { get; set; }

        public AccessControlList StateACL { get; set; }

        public bool TransitionsRequireEditAccessToObject { get; set; }
    }
}
