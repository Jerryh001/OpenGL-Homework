#pragma once
#include"stdafx.h"
#include"Shader.h"
struct Vertex
{
	vec3 Position;
};
class Mesh
{
	GLuint VAO, VBO, EBO;
	void setupMesh();
public:
	vector<Vertex> vertices;
	vector<GLuint> indices;
	Mesh(vector<Vertex> vertices, vector<GLuint> indices);
	void Draw();
};