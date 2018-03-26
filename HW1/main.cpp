#include "stdafx.h"



GLFWwindow* CreateGLWindow()
{
	int width=600, height=600;

	///Init
	if (glfwInit() == GL_FALSE)
	{
		exit(EXIT_FAILURE);
	}
	

	///Auto release when exit
	atexit(glfwTerminate);


	///Set OpenGL version to 3.3
	glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, 3);
	glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, 3);


	glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);

	///Set window not resizable
	//glfwWindowHint(GLFW_RESIZABLE, GL_FALSE);

	///Create window and get handle
	GLFWwindow* window = glfwCreateWindow(width, height, u8"甜甜圈", nullptr, nullptr);
	if (window == nullptr)
	{
		cout << "Failed to create GLFW window" << endl;
		exit(EXIT_FAILURE);
	}


	glfwMakeContextCurrent(window);

	glewExperimental = GL_TRUE;
	if (glewInit() != GLEW_OK)
	{
		exit(EXIT_FAILURE);
	}
	glEnable(GL_DEPTH_TEST);
	glViewport(0, 0, width, height);

	glfwSetFramebufferSizeCallback(window, [](GLFWwindow* window, int width, int height) {glViewport(0, 0, width, height); });

	return window;

}
string readfile(const string& filename)
{
	ifstream in(filename);
	//string s;
	return string(istreambuf_iterator<char>(in),istreambuf_iterator<char>());
}

GLuint ShaderSet(GLenum type, const string& filename)
{
	GLuint Shader = glCreateShader(type);
	string source = readfile(filename);
	const GLchar* ShaderSource = source.c_str();
	glShaderSource(Shader, 1, &ShaderSource, nullptr);
	glCompileShader(Shader);
	GLint success;
	GLchar infoLog[512];
	glGetShaderiv(Shader, GL_COMPILE_STATUS, &success);
	if (!success)
	{
		glGetShaderInfoLog(Shader, 512, NULL, infoLog);
		std::cout << "ERROR::SHADER::"<< filename<<"::COMPILATION_FAILED\n" << infoLog << std::endl;
	}
	return Shader;
}
GLuint CreateShader()
{
	GLuint vertexShader = ShaderSet(GL_VERTEX_SHADER, "vertex.vert");

	GLuint fragmentShader = ShaderSet(GL_FRAGMENT_SHADER, "fragment.frag");

	GLuint shaderProgram = glCreateProgram();
	glAttachShader(shaderProgram, vertexShader);
	glAttachShader(shaderProgram, fragmentShader);
	glLinkProgram(shaderProgram);
	GLint success;
	glGetProgramiv(shaderProgram, GL_LINK_STATUS, &success);
	char infoLog[600];
	if (!success) {
		glGetProgramInfoLog(shaderProgram, 512, NULL, infoLog);
		std::cout << "ERROR::SHADER::PROGRAM::LINKING_FAILED\n" << infoLog << std::endl;
	}

	glDeleteShader(vertexShader);
	glDeleteShader(fragmentShader);
	return shaderProgram;
}

pair<vector<GLfloat>, vector<GLuint> > TorusCreate()
{
	vector<GLfloat> vertex;
	vector<GLuint> index;
	
	GLfloat R = 0.6f;
	GLfloat r = 0.2f;
	const int detail = 32;
	for (int i = 0; i < detail; i++)
	{
		for (int j = 0; j < detail; j++)
		{
			vertex.push_back((R + r * cos(2 * M_PI* j / detail))*cos(2 * M_PI* i / detail));
			vertex.push_back((R + r * cos(2 * M_PI* j / detail))*sin(2 * M_PI* i / detail));
			vertex.push_back(r * sin(2 * M_PI* j / detail));

			index.push_back(i * detail + j);
			index.push_back((i + 1) % detail * detail + j);
			index.push_back((i + 1) % detail * detail + (j + 1) % detail);

			index.push_back(i * detail + j);
			index.push_back(i * detail + (j + 1) % detail);
			index.push_back((i + 1) % detail * detail + (j + 1) % detail);

		}
	}
	return pair<vector<GLfloat>, vector<GLuint> >(vertex, index);

}


int main()
{
	FreeConsole();

	GLFWwindow* window=CreateGLWindow();

	GLint shaderProgram = CreateShader();
	
	
	pair<vector<GLfloat>, vector<GLuint> > torus = TorusCreate();
	
	GLuint VBO;
	glGenBuffers(1, &VBO);//size,array

	GLuint VAO;
	glGenVertexArrays(1, &VAO);

	GLuint EBO;
	glGenBuffers(1, &EBO);

	glBindVertexArray(VAO);

	glBindBuffer(GL_ARRAY_BUFFER, VBO);
	glBufferData(GL_ARRAY_BUFFER, sizeof(GLfloat)*torus.first.size(), torus.first.data(), GL_STATIC_DRAW);

	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, EBO);
	glBufferData(GL_ELEMENT_ARRAY_BUFFER, sizeof(GLuint)*torus.second.size(), torus.second.data(), GL_STATIC_DRAW);

	glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, 3 * sizeof(GLfloat), 0);
	glEnableVertexAttribArray(0);
	
	glBindBuffer(GL_ARRAY_BUFFER, 0);
	glBindVertexArray(0);
	

	
	while (!glfwWindowShouldClose(window))
	{
		glfwPollEvents();
		glClearColor(0.2f, 0.3f, 0.3f, 1.0f);
		glClear(GL_COLOR_BUFFER_BIT|GL_DEPTH_BUFFER_BIT);


		glUseProgram(shaderProgram);

		mat4 model;
		model = rotate(model, static_cast<float>(glfwGetTime()), vec3(1.0f, 1.0f, 0.0f));

		GLint vertexColorLocation = glGetUniformLocation(shaderProgram, "rotate");
		glUniformMatrix4fv(vertexColorLocation, 1,GL_FALSE,value_ptr(model));


		glBindVertexArray(VAO);

		glDrawElements(GL_TRIANGLES, torus.second.size()*3, GL_UNSIGNED_INT, 0);

		glBindVertexArray(0);

		

		glfwSwapBuffers(window);
	}
	
	glDeleteVertexArrays(1, &VAO);
	glDeleteBuffers(1, &VBO);

	return 0;
	
}