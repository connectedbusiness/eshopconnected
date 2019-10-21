You will need to add the appropriate reference paths to each project before it will build.
Add the references in the specificed order, then build that project
Below are the references needed for my environment.

David Nelson
www.dynenttech.com

    IN THIS ORDER

    Lerryn.Framework.ImportExport
	Compile, Build output path: 
		..\..\DLL\
	Add reference path
		C:\Program Files (x86)\Connected Business Enterprise\eShopCONNECTED\
	Build

    Lerryn.Extendable.ImportExport
	Compile, Build output path: 
		..\..\DLL\
	Add reference path
		..\..\DLL\     (browse and select the path)
		C:\Program Files (x86)\Connected Business Enterprise\eShopCONNECTED\
	Build

    Lerryn.Facade.ImportExport
	Compile, Build output path: 
		..\..\DLL\
	Add reference path
		C:\Program Files (x86)\Connected Business Enterprise\eShopCONNECTED\
		C:\Program Files (x86)\Connected Business Client\
	Build

    Lerryn.Presentation.eShopCONNECT
	Compile, Build output path: 
		..\..\DLL\
	Add reference path
		..\..\DLL\     (browse and select the path)
		C:\Program Files (x86)\Connected Business Enterprise\eShopCONNECTED\
		C:\Program Files (x86)\Connected Business Client\
	Build

    Lerryn.Business.ImportExport
	Compile, Build output path: 
		..\..\DLL\
	Build

    Lerryn.WindowsService.eShopCONNECT
	Compile, Build output path: 
		..\..\DLL\
	Add reference path
		..\..\DLL\     (browse and select the path)
		C:\Program Files (x86)\Connected Business Enterprise\eShopCONNECTED\

    Lerryn.WindowsService.eShopCONNECT.UnitTest
	Add reference path
		..\..\DLL\     (browse and select the path)
		C:\Program Files (x86)\Connected Business Enterprise\eShopCONNECTED\

