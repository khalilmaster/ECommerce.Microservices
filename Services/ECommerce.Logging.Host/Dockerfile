﻿FROM microsoft/dotnet:2.0.4-runtime

WORKDIR /app
COPY /bin/Debug/netcoreapp2.0/publish .

ENTRYPOINT ["dotnet", "ECommerce.Logging.Host.dll"]