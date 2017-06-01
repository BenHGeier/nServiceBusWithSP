# nServiceBusWithSP
Repro of nServiceBus Using SharePoint
This repro takes the standard nServiceBus 'Getting Started' solution, and adds a new class library (ClassLibraryThatUserSharePoint).
The new class library references the Microsoft.SharePoint.dll assembly (all required Sharepoint assemblies are included in the 
'References' solution folder).
The ClientUI project has been updated to reference the ClassLibraryThatUserSharePoint project. The ClientUI project will not 
start when referencing this new assembly - maybe because nServiceBus is scanning the SharePoint assemblies (even though the 
SharePoint assemblies are being added to the list of 'ExcludeAssemblies' in the endpointConfiguration.
