@ECHO Packaging Native Libraries
dotnet restore GridInQuestIINet.Native.sln
dotnet pack --no-build --no-restore --configuration Release GridInQuestIINet.Native.sln

@ECHO Building and Packaging Managed Wrapper Library
dotnet restore GridInQuestIINet\GridInQuestIINet.csproj
dotnet build --configuration Release GridInQuestIINet\GridInQuestIINet.csproj
dotnet pack --no-build --no-restore --configuration Release GridInQuestIINet\GridInQuestIINet.csproj
