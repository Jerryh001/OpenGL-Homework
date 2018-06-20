#include "stdafx.h"
#include "Shader.h"


string Shader::ReadFile(const string & path)
{
	ifstream file(path);
	return string(istreambuf_iterator<char>(file), istreambuf_iterator<char>());
}

GLuint Shader::CompileShader(const GLenum & shaderType, const string & code)
{
	GLuint result = glCreateShader(shaderType);
	const GLchar* codechar = code.c_str();
	glShaderSource(result, 1, &codechar, NULL);
	glCompileShader(result);
	glGetShaderiv(result, GL_COMPILE_STATUS, &success);
	if (!success)
	{
		glGetShaderInfoLog(result, 512, nullptr, infoLog);
		cout << "ERROR::SHADER::COMPILATION_FAILED\n" << infoLog << endl;
	};
	return result;
}

GLuint Shader::LinkProgram(const GLuint & vertex, const GLuint & fragment)
{
	GLuint P = glCreateProgram();
	glAttachShader(P, vertex);
	glAttachShader(P, fragment);
	glLinkProgram(P);
	// 打印连接错误（如果有的话）
	glGetProgramiv(this->Program, GL_LINK_STATUS, &success);
	if (!success)
	{
		glGetProgramInfoLog(this->Program, 512, nullptr, infoLog);
		cout << "ERROR::SHADER::PROGRAM::LINKING_FAILED\n" << infoLog << endl;
	}
	return P;
}

Shader::Shader(const string& vertexPath, const string& fragmentPath)
{
	string vShaderCode = ReadFile(vertexPath);
	string fShaderCode = ReadFile(fragmentPath);

	GLuint vertex = CompileShader(GL_VERTEX_SHADER, vShaderCode);
	GLuint fragment = CompileShader(GL_FRAGMENT_SHADER, fShaderCode);

	Program = LinkProgram(vertex, fragment);

	glDeleteShader(vertex);
	glDeleteShader(fragment);
}

void Shader::Use()
{
	glUseProgram(Program);
}

Shader::operator GLuint()
{
	return Program;
}
