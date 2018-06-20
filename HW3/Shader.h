#pragma once
#include"stdafx.h"
class Shader
{
	GLint success;
	GLchar infoLog[512];

	GLuint Program;
	string ReadFile(const string& path);
	GLuint CompileShader(const GLenum& shaderType,const string& code);
	GLuint LinkProgram(const GLuint& vertex,const GLuint& fragment);
public:
	
	Shader(const string& vertexPath, const string& fragmentPath);
	void Use();
	operator GLuint();
};

