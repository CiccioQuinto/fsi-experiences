//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CloudForFSI.OptionSets
{
	using Microsoft.CloudForFSI.Tables;
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum msfsi_Documentstatus
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Approved", 2)]
		Approved = 104800003,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Missing file", 0)]
		Missingfile = 104800000,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Pending review", 1)]
		Pendingreview = 104800001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Rejected", 3)]
		Rejected = 104800004,
	}
}