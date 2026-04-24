namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2d802465-618f-4fe4-b1ad-c0f629c5727c");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("11a851e4-8474-4a61-a177-ae5b204389cc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,109,139,211,64,16,199,223,7,252,14,67,94,37,80,22,239,173,213,3,91,170,28,28,42,215,84,16,241,197,118,51,77,87,246,33,236,108,122,86,233,119,119,31,122,181,105,79,116,32,144,204,254,247,55,243,159,140,225,26,169,231,2,161,65,231,56,217,141,103,115,107,54,178,27,28,247,210,154,226,87,1,33,6,146,166,131,229,158,60,234,233,89,230,252,150,214,214,252,237,204,33,91,24,47,189,68,250,15,9,91,236,208,248,163,242,107,202,238,83,234,94,134,6,12,186,106,41,182,168,249,135,208,61,188,129,114,69,238,11,23,91,95,214,223,210,149,126,88,43,41,64,40,78,4,233,228,25,6,188,130,25,39,124,230,36,49,178,239,51,154,221,133,102,101,139,176,179,178,133,143,102,201,119,193,66,101,215,223,81,120,32,52,45,186,9,100,220,12,55,193,79,130,190,117,29,1,214,39,218,31,110,140,117,232,128,157,88,79,16,172,167,35,85,134,194,62,58,9,126,171,252,93,103,249,88,218,162,144,154,43,232,157,20,113,54,233,14,123,143,190,217,247,216,206,173,26,180,249,204,213,128,175,143,202,219,42,142,239,83,148,151,23,101,229,6,170,204,185,133,155,151,41,234,145,96,236,37,6,178,59,154,115,35,80,97,27,170,123,55,224,180,184,82,145,119,241,239,135,213,35,222,97,131,186,87,220,199,110,13,62,194,189,21,92,201,159,124,173,112,153,116,85,246,176,34,116,97,53,77,152,118,216,75,246,128,100,7,39,130,198,186,0,153,188,184,170,18,227,180,26,121,163,202,9,148,87,124,98,105,32,119,212,88,59,147,93,254,42,107,214,216,99,253,250,159,22,66,235,57,193,222,89,167,185,175,46,172,133,178,55,16,198,151,158,197,234,225,114,210,49,252,214,217,199,52,129,197,15,129,125,52,249,132,185,80,31,138,241,219,161,56,20,191,1,104,182,179,7,201,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d4232ac2-2eb8-491c-1e3f-7118fa0db92c"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("11a851e4-8474-4a61-a177-ae5b204389cc"),
				CreatedInSchemaUId = new Guid("2d802465-618f-4fe4-b1ad-c0f629c5727c"),
				ModifiedInSchemaUId = new Guid("2d802465-618f-4fe4-b1ad-c0f629c5727c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2d802465-618f-4fe4-b1ad-c0f629c5727c"));
		}

		#endregion

	}

	#endregion

}

