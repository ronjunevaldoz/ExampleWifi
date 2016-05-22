# C# Application - How to create a basic WiFi hotspot
How to enable disable internet sharing of a virtual wireless adapter using C# programming
## Getting Started
Youtube - https://www.youtube.com/watch?v=cU4CL0Av-1k&list=PLfj229q5dYilteQLlR_u7e1XXwHMkjS_U
1. Must run the solution/exe as Administrator

### Initialize Hotspot
```C#
Hotpost h = new Hotspot();
```
### GetConnections() - list all network connections
```C#
h.GetConnections(); // to List all network connections
// Basic usage
h.GetConnections().ForEach(conProp => { cmbConnection.Items.Add(conProp); });
```
### Create virtual wifi adapter
```C#
h.Create(SSID , KEY); // create a virtual wifi adapter
h.Start(); // start the created virtual wifi adapter
```
### Disable/Enable Internet Sharing
```C#
h.ShareInternet("Ethernet", LOCAL AREA NETWORK NAME, true); // enable internet sharing from source connectiom
h.ShareInternet("Ethernet", LOCAL AREA NETWORK NAME, false); // disable internet sharing from source connectiom
```
### Stop the created virtual wifi adapter
```C#
h.Stop();
```
