set WORKSPACE=..
set UnityBase=..\..

set GEN_CLIENT=%WORKSPACE%\Luban\Luban.ClientServer\Luban.ClientServer.exe
set CONF_ROOT=%WORKSPACE%\Luban\MiniDesignerConfigsTemplate


%GEN_CLIENT% -j cfg --^
 -d %CONF_ROOT%\Defines\__root__.xml ^
 --input_data_dir %CONF_ROOT%\Datas ^
 --naming_convention:module none  ^
 --naming_convention:bean_member none  ^
 --naming_convention:enum_member none  ^
 --input:convert:data_dir %WORKSPACE%\Luban\Json_Data ^
 --output_data_dir conver_json_to_xlsx ^
 --gen_types convert_xlsx ^
 -s all


pause