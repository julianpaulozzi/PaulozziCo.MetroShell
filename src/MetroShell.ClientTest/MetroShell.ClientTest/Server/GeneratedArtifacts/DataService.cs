﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Data Services
    
    /// <summary>
    /// Provides members to query and update data in the ApplicationData datasource.
    /// </summary>
    public sealed partial class ApplicationDataService
        : global::LightSwitchApplication.ApplicationData
    {
        #region Constructors
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public ApplicationDataService() : base()
        {
        }
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.Application Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Server Interceptions Points
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientesSet_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientesSet_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientesSet_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientesSet_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientesSet_Inserting(global::LightSwitchApplication.Clientes entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientesSet_Inserted(global::LightSwitchApplication.Clientes entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientesSet_Updating(global::LightSwitchApplication.Clientes entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientesSet_Updated(global::LightSwitchApplication.Clientes entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientesSet_Deleting(global::LightSwitchApplication.Clientes entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientesSet_Deleted(global::LightSwitchApplication.Clientes entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientesSet_Validate(global::LightSwitchApplication.Clientes entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ClientesSet_Filter(ref global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Clientes, bool>> filter);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Grupoes_CanInsert(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Grupoes_CanUpdate(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Grupoes_CanDelete(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Grupoes_CanRead(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Grupoes_Inserting(global::LightSwitchApplication.Grupo entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Grupoes_Inserted(global::LightSwitchApplication.Grupo entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Grupoes_Updating(global::LightSwitchApplication.Grupo entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Grupoes_Updated(global::LightSwitchApplication.Grupo entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Grupoes_Deleting(global::LightSwitchApplication.Grupo entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Grupoes_Deleted(global::LightSwitchApplication.Grupo entity);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Grupoes_Validate(global::LightSwitchApplication.Grupo entity, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder results);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Grupoes_Filter(ref global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Grupo, bool>> filter);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_CanExecute(ref bool result);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executing();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_Executed();
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void SaveChanges_ExecuteFailed(global::System.Exception exception);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_Executing(global::Microsoft.LightSwitch.QueryExecutingDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_Executed(global::Microsoft.LightSwitch.QueryExecutedDescriptor queryDescriptor);
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Query_ExecuteFailed(global::Microsoft.LightSwitch.QueryExecuteFailedDescriptor queryDescriptor);
    
        #endregion
    
        #region Details Class
    
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        public static new class DetailsClass
        {
    
            static DetailsClass()
            {
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Clientes>
                __ClientesSetEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Clientes>(
                    "ClientesSet",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ClientesSet_CanInsert,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ClientesSet_CanUpdate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ClientesSet_CanDelete,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ClientesSet_CanRead,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ClientesSet_Inserting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ClientesSet_Inserted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ClientesSet_Updating,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ClientesSet_Updated,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ClientesSet_Deleting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ClientesSet_Deleted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ClientesSet_Validate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__ClientesSet_Filter);
            private static bool __ClientesSet_CanInsert(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.ClientesSet_CanInsert(ref result);
                return result;
            }
            private static bool __ClientesSet_CanUpdate(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.ClientesSet_CanUpdate(ref result);
                return result;
            }
            private static bool __ClientesSet_CanDelete(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.ClientesSet_CanDelete(ref result);
                return result;
            }
            private static bool __ClientesSet_CanRead(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.ClientesSet_CanRead(ref result);
                return result;
            }
            private static void __ClientesSet_Inserting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Clientes e)
            {
                d.ClientesSet_Inserting(e);
            }
            private static void __ClientesSet_Inserted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Clientes e)
            {
                d.ClientesSet_Inserted(e);
            }
            private static void __ClientesSet_Updating(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Clientes e)
            {
                d.ClientesSet_Updating(e);
            }
            private static void __ClientesSet_Updated(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Clientes e)
            {
                d.ClientesSet_Updated(e);
            }
            private static void __ClientesSet_Deleting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Clientes e)
            {
                d.ClientesSet_Deleting(e);
            }
            private static void __ClientesSet_Deleted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Clientes e)
            {
                d.ClientesSet_Deleted(e);
            }
            private static void __ClientesSet_Validate(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Clientes e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.ClientesSet_Validate(e, r);
            }
            private static global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Clientes, bool>> __ClientesSet_Filter(global::LightSwitchApplication.ApplicationDataService d)
            {
                global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Clientes, bool>> filter = null;
                d.ClientesSet_Filter(ref filter);
                return filter;
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Grupo>
                __GrupoesEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.EntitySetEntry<global::LightSwitchApplication.ApplicationDataService, global::LightSwitchApplication.Grupo>(
                    "Grupoes",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Grupoes_CanInsert,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Grupoes_CanUpdate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Grupoes_CanDelete,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Grupoes_CanRead,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Grupoes_Inserting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Grupoes_Inserted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Grupoes_Updating,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Grupoes_Updated,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Grupoes_Deleting,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Grupoes_Deleted,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Grupoes_Validate,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Grupoes_Filter);
            private static bool __Grupoes_CanInsert(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Grupoes_CanInsert(ref result);
                return result;
            }
            private static bool __Grupoes_CanUpdate(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Grupoes_CanUpdate(ref result);
                return result;
            }
            private static bool __Grupoes_CanDelete(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Grupoes_CanDelete(ref result);
                return result;
            }
            private static bool __Grupoes_CanRead(global::LightSwitchApplication.ApplicationDataService d)
            {
                bool result = true;
                d.Grupoes_CanRead(ref result);
                return result;
            }
            private static void __Grupoes_Inserting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Grupo e)
            {
                d.Grupoes_Inserting(e);
            }
            private static void __Grupoes_Inserted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Grupo e)
            {
                d.Grupoes_Inserted(e);
            }
            private static void __Grupoes_Updating(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Grupo e)
            {
                d.Grupoes_Updating(e);
            }
            private static void __Grupoes_Updated(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Grupo e)
            {
                d.Grupoes_Updated(e);
            }
            private static void __Grupoes_Deleting(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Grupo e)
            {
                d.Grupoes_Deleting(e);
            }
            private static void __Grupoes_Deleted(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Grupo e)
            {
                d.Grupoes_Deleted(e);
            }
            private static void __Grupoes_Validate(global::LightSwitchApplication.ApplicationDataService d, global::LightSwitchApplication.Grupo e, global::Microsoft.LightSwitch.EntitySetValidationResultsBuilder r)
            {
                d.Grupoes_Validate(e, r);
            }
            private static global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Grupo, bool>> __Grupoes_Filter(global::LightSwitchApplication.ApplicationDataService d)
            {
                global::System.Linq.Expressions.Expression<global::System.Func<global::LightSwitchApplication.Grupo, bool>> filter = null;
                d.Grupoes_Filter(ref filter);
                return filter;
            }
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>
                __SaveChangesEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.OperationEntry<global::LightSwitchApplication.ApplicationDataService>(
                    "SaveChanges",
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_CanExecute,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__SaveChanges_Failed);
            private static bool __SaveChanges_CanExecute(global::LightSwitchApplication.ApplicationDataService d, bool r)
            {
                d.SaveChanges_CanExecute(ref r);
                return r;
            }
            private static void __SaveChanges_Executing(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executing();
            }
            private static void __SaveChanges_Executed(global::LightSwitchApplication.ApplicationDataService d, object[] args)
            {
                d.SaveChanges_Executed();
            }
            private static void __SaveChanges_Failed(global::LightSwitchApplication.ApplicationDataService d, object[] args, global::System.Exception ex)
            {
                d.SaveChanges_ExecuteFailed(ex);
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Server.QueryEntry<global::LightSwitchApplication.ApplicationDataService>
                ___QueryEntry = new global::Microsoft.LightSwitch.Details.Framework.Server.QueryEntry<global::LightSwitchApplication.ApplicationDataService>(
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Executing,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Executed,
                    global::LightSwitchApplication.ApplicationDataService.DetailsClass.__Query_Failed);
            private static void __Query_Executing(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecutingDescriptor queryDescriptor)
            {
                d.Query_Executing(queryDescriptor);
            }
            private static void __Query_Executed(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecutedDescriptor queryDescriptor)
            {
                d.Query_Executed(queryDescriptor);
            }
            private static void __Query_Failed(global::LightSwitchApplication.ApplicationDataService d, global::Microsoft.LightSwitch.QueryExecuteFailedDescriptor queryDescriptor)
            {
                d.Query_ExecuteFailed(queryDescriptor);
            }
        }
    
        #endregion
    }
    
    #endregion
}
