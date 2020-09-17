﻿using System;
using System.Text.RegularExpressions;
using k8s;
using k8s.Models;

namespace K8sControllerSDK
{
	public abstract class BaseCRD : IMetadata<V1ObjectMeta>
	{
		protected BaseCRD(string group, string version, string plural, string singular)
		{
			Group = group;
			Version = version;
			Plural = plural;
			Singular = singular;
		}

		public string Group { get; protected set; }
		public string Version { get; protected set; }
		public string Plural { get; protected set; }
		public string Singular { get; protected set; }
		public string StatusAnnotationName { get => string.Format($"{Group}/{Singular}-status"); }

		public string Status => Metadata.Annotations.ContainsKey(StatusAnnotationName) ? Metadata.Annotations[StatusAnnotationName] : null;
		public string ApiVersion { get; set; }
		public string Kind { get; set; }

		public V1ObjectMeta Metadata { get; set; }

	}
}