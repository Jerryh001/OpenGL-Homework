// stdafx.h : 可在此標頭檔中包含標準的系統 Include 檔，
// 或是經常使用卻很少變更的
// 專案專用 Include 檔案
//

#pragma once

#include "targetver.h"
#define _USE_MATH_DEFINES
#include<string>
#include<fstream>
#include<iostream>
#include<vector>
#include<cmath>
#include<Windows.h>
using namespace std;

#define GLM_FORCE_RADIANS
#pragma comment(lib, "opengl32.lib")

#include "GL/glew.h"
#include "GLFW/glfw3.h"
#include "glm/glm.hpp"
#include "glm/gtc/type_ptr.hpp"
#include "glm/gtc/matrix_transform.hpp"
using namespace glm;

#include "assimp/Importer.hpp"
#include "assimp/scene.h"
#include "assimp/postprocess.h"
using namespace Assimp;