$executing_script_directory = Split-Path -Path $MyInvocation.MyCommand.Definition -Parent
$postmark_server_token = "token"

function Load-Module([string] $assembly_lib_path)
{
    if(!$assembly_lib_path)
    {
        throw "argument"
    }

    $lib_folder_path = Join-Path $executing_script_directory "lib"
    $full_lib_path =  Join-Path $lib_folder_path $assembly_lib_path
    Import-Module $full_lib_path
}

function Load-Postmark-Lib()
{
    Load-Module "Hammock.dll"
    Load-Module "Newtonsoft.Json.dll"
    Load-Module "PostmarkDotNet.dll"
    Load-Module "AppHarbor.PowerShell.Postmark.PSSnapIn.dll"
}

function Send-Email()
{
    $postmark_client = Get-PostmarkClient -ServerToken $postmark_server_token
    $response = $postmark_client | Send-PostmarkEmail "from@example.com" "to@example.com" "subject" "body"
}

function Main()
{
    Load-Postmark-Lib
    Send-Email
}

Main
