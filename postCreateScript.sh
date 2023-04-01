#/bin/bash
echo "Initialize startup script!"

echo "updating apt.."
apt update
echo "installing wget"
apt install wget
echo "Downloading dotnet install script"
wget https://dot.net/v1/dotnet-install.sh -O /tmp/dotnet-install.sh
chmod +x /tmp/dotnet-install.sh
echo "Executing dotnet-install script"
bash -c /tmp/dotnet-install.sh
echo "This is the path:" 
echo $PATH
echo "setting path..."
export PATH=$PATH:/root/.dotnet/
echo "Updated path: $PATH"
echo "Testing dotnet command..."
dotnet --help
echo "startup script finished!"