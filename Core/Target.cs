using Lextm.SharpSnmpLib;

namespace Snmp.Core
{
    internal class Target
    {
        #region Contructors
        public Target(string ip, string community, string oid)
        {
            Ip = ip;
            CommunityName = community;
            Oid = oid;
        }

        // Ones
        public Target(string ip, ushort port, string community, string oid) : this(ip, community, oid) => Port = port;
        public Target(string ip, string community, string oid, string devId) : this(ip, community, oid) => DeviceId = devId;
        public Target(string ip, string community, string oid, VersionCode version) : this(ip, community, oid) => VersionCode = version;

        // Twos
        public Target(string ip, ushort port, string community, string oid, VersionCode version) : this(ip, community, oid)
        {
            Port = port;
            VersionCode = version;
        }
        public Target(string ip, ushort port, string community, string oid, string devId) : this(ip, community, oid)
        {
            Port = port;
            DeviceId = devId;
        }
        public Target(string ip, string community, string oid, string devId, VersionCode version) : this(ip, community, oid)
        {
            DeviceId = devId;
            VersionCode = version;
        }

        // Three
        public Target(string ip, ushort port, string community, string oid, string devId, VersionCode version) : this(ip, community, oid)
        {
            Port = port;
            DeviceId = devId;
            VersionCode = version;
        }
        #endregion

        public string Ip { get; } = string.Empty;
        public ushort Port { get; } = 161;
        public string CommunityName { get; } = string.Empty;
        public string Oid { get; } = string.Empty;
        public string DeviceId { get; } = string.Empty;
        public VersionCode VersionCode { get; } = VersionCode.V1;

        public Target ChangeOid(string newId) => new Target(ip: Ip, port: Port, community: CommunityName, oid: newId, version: VersionCode);
        public Target ChangeDeviceId(string newDeviceId) => new Target(ip: Ip, port: Port, community: CommunityName, oid: Oid, devId: newDeviceId, version: VersionCode);
    }
}
