#pragma once
#include"stdafx.h"
#include"Mesh.h"
class Model
{
	void loadModel(string path);
	void processNode(aiNode* node, const aiScene* scene);
	Mesh processMesh(aiMesh* mesh, const aiScene* scene);
public:
	vector<Mesh> meshes;
	Model(const GLchar* path);
	void Draw();
private:
	
};
