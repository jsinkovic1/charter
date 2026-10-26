FROM mcr.microsoft.com/dotnet/sdk:10.0
ADD . /root
WORKDIR /root
#ENV PATH="/bin/dotnet"
RUN echo "Starting build..."
RUN dotnet build /root/backend/CharterBackend.csproj
ENTRYPOINT ["dotnet", "/root/backend/bin/Debug/net10.0/CharterBackend.dll"]