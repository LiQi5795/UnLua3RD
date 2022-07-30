// Tencent is pleased to support the open source community by making UnLua available.
//
// Copyright (C) 2019 THL A29 Limited, a Tencent company. All rights reserved.
//
// Licensed under the MIT License (the "License");
// you may not use this file except in compliance with the License. You may obtain a copy of the License at
//
// http://opensource.org/licenses/MIT
//
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

#include "UnLuaExtensionsModule.h"

#include <Windows.Data.Text.h>

#include "LuaEnv.h"
#include "luasocket.h"


extern "C"
{
#include "lua-crypt.h"
#include "lptree.h"
#include "lsproto.h"
}



void FUnLuaExtensionsModule::StartupModule()
{
    Handle = UnLua::FLuaEnv::OnCreated.AddStatic(&FUnLuaExtensionsModule::OnLuaEnvCreated);

    for (const auto &Pair : UnLua::FLuaEnv::GetAll())
        OnLuaEnvCreated(*Pair.Value);
}

void FUnLuaExtensionsModule::ShutdownModule()
{
    UnLua::FLuaEnv::OnCreated.Remove(Handle);
}


void FUnLuaExtensionsModule::OnLuaEnvCreated(UnLua::FLuaEnv &Env)
{

    Env.AddBuiltInLoader(TEXT("socket"), luaopen_socket_core);
    Env.AddBuiltInLoader(TEXT("socket.core"), luaopen_socket_core);
    Env.AddBuiltInLoader(TEXT("crypt"), luaopen_crypt);
    Env.AddBuiltInLoader(TEXT("lpeg"), luaopen_lpeg);
    Env.AddBuiltInLoader(TEXT("sproto.core"), luaopen_sproto_core);
}


IMPLEMENT_MODULE(FUnLuaExtensionsModule, UnLuaExtensions)
