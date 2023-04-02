# BlueArchiveAPI
Blue Archive Server API Implementation (partial)

## Usage

1. **By certain means**, redirect the original server_config request of the game:
`https://d2vaidpni345rp.cloudfront.net/com.nexon.bluearchive/server_config/{ClientBuild_Revision}_Live.json`
to:
`http://{server_host}/suffix2333/com.nexon.bluearchive/server_config/{ClientBuild_Revision}_Live.json`
2. Set property `cleartextTrafficPermitted` to `True` in `networkSecurityConfig` of the game app. If you have a https certicate, you can switch the server to `https` protocol and ignore this step.
3. Enjoy
