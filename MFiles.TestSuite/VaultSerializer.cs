﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using MFiles.TestSuite.ComModels;
using MFilesAPI;
using Newtonsoft.Json;

namespace MFiles.TestSuite
{
    public static class VaultSerializer
    {
        public static string Objects(Vault vault)
        {
            var vaultOTs = vault.ObjectTypeOperations.GetObjectTypesAdmin();

            var objects = new List<xObjTypeAdmin>();
            foreach (ObjTypeAdmin item in vaultOTs)
            {
                //if(!item.ObjectType.RealObjectType)
                //    continue; // TODO: maybe??
                objects.Add(new xObjTypeAdmin(item));                
            }

            return JsonConvert.SerializeObject(objects);
        }

        public static string Classes(Vault vault)
        {
            var vaultClasses = vault.ClassOperations.GetAllObjectClassesAdmin();

            var classes = new List<xObjectClassAdmin>();
            foreach (ObjectClassAdmin item in vaultClasses)
            {
                classes.Add(new xObjectClassAdmin(item));                
            }
            return JsonConvert.SerializeObject(classes);
        }

        public static string Properties(Vault vault)
        {
            var vaultProperties = vault.PropertyDefOperations.GetPropertyDefsAdmin();
            var properties = new List<xPropertyDefAdmin>();
            foreach (PropertyDefAdmin item in vaultProperties)
            {
                properties.Add(new xPropertyDefAdmin(item));
            }
            return JsonConvert.SerializeObject(properties);
        }

        public static string ValueLists(Vault vault)
        {
            var vaultVl = vault.ValueListOperations.GetValueLists();

            var valueLists = new List<xObjType>();
            foreach (ObjType item in vaultVl)
            {
                valueLists.Add(new xObjType(item));                
            }
            return JsonConvert.SerializeObject(valueLists);
        }

        public static string Workflows(Vault vault)
        {
            var vaultWorkflows = vault.WorkflowOperations.GetWorkflowsAdmin();

            var workflows = new List<xWorkflowAdmin>();
            foreach (WorkflowAdmin item in vaultWorkflows)
            {
                workflows.Add(new xWorkflowAdmin(item));                
            }
            return JsonConvert.SerializeObject(workflows);
        }

    }
}
