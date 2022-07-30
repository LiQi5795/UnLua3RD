# UnLua3rd

UnLua整合第三方纯C库, 支持UE5.X

## 时间比较少,仅支持

 lua crypt 
 
 lua lpeg
 
 lua sproto


## 使用方法
直接在脚本中require即可

 local crypt = require "crypt"
 
 local lpeg = require "lpeg"

 使用sproto时候, 还需要两个必要的lua文件. 
 
 sproto.lua
 
 sprotoparser.lua
 
 前往https://github.com/cloudwu/sproto 获取

## *注意

 库中源码是经过修改的.切勿用官方源文件 
