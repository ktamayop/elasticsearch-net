﻿using Newtonsoft.Json;

namespace Nest
{
	public interface ICancelClusterRerouteCommand : IClusterRerouteCommand
	{
		[JsonProperty("allow_primary")]
		bool? AllowPrimary { get; set; }

		[JsonProperty("index")]
		IndexName Index { get; set; }

		[JsonProperty("node")]
		string Node { get; set; }

		[JsonProperty("shard")]
		int? Shard { get; set; }
	}

	public class CancelClusterRerouteCommand : ICancelClusterRerouteCommand
	{
		public bool? AllowPrimary { get; set; }

		public IndexName Index { get; set; }
		public string Name => "cancel";

		public string Node { get; set; }

		public int? Shard { get; set; }
	}

	public class CancelClusterRerouteCommandDescriptor
		: DescriptorBase<CancelClusterRerouteCommandDescriptor, ICancelClusterRerouteCommand>, ICancelClusterRerouteCommand
	{
		bool? ICancelClusterRerouteCommand.AllowPrimary { get; set; }

		IndexName ICancelClusterRerouteCommand.Index { get; set; }
		string IClusterRerouteCommand.Name => "cancel";

		string ICancelClusterRerouteCommand.Node { get; set; }

		int? ICancelClusterRerouteCommand.Shard { get; set; }

		public CancelClusterRerouteCommandDescriptor Index(IndexName index) => Assign(a => a.Index = index);

		public CancelClusterRerouteCommandDescriptor Index<T>() where T : class => Assign(a => a.Index = typeof(T));

		public CancelClusterRerouteCommandDescriptor Shard(int? shard) => Assign(a => a.Shard = shard);

		public CancelClusterRerouteCommandDescriptor Node(string node) => Assign(a => a.Node = node);

		public CancelClusterRerouteCommandDescriptor AllowPrimary(bool? allowPrimary = true) => Assign(a => a.AllowPrimary = allowPrimary);
	}
}
