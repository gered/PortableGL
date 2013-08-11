using System;

namespace PortableGL
{
	public abstract partial class GL20
	{
		public unsafe void glBufferData<T>(int target, int size, T[] data, int usage) where T : struct
		{
			fixed (void* ptr = data)
			{
				glBufferData(target, size, new IntPtr((long)ptr), usage);
			}
		}

		public unsafe void glBufferSubData<T>(int target, int offset, int size, T[] data) where T : struct
		{
			fixed (void* ptr = data)
			{
				glBufferSubData(target, offset, size, new IntPtr((long)ptr));
			}
		}

		public unsafe void glCompressedTexImage2D<T>(int target, int level, int internalformat, int width, int height, int border, int imageSize, T[] data) where T : struct
		{
			fixed (void* ptr = data)
			{
				glCompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, new IntPtr((long)ptr));
			}
		}

		public unsafe void glCompressedTexSubImage2D<T>(int target, int level, int xoffset, int yoffset, int width, int height, int format, int imageSize, T[] data) where T : struct
		{
			fixed (void* ptr = data)
			{
				glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, new IntPtr((long)ptr));
			}
		}

		public unsafe void glDeleteBuffers(int n, int[] buffers)
		{
			fixed (void* ptr = buffers)
			{
				glDeleteBuffers(n, new IntPtr((long)ptr));
			}
		}

		public unsafe void glDeleteFramebuffers(int n, int[] framebuffers)
		{
			fixed (void* ptr = framebuffers)
			{
				glDeleteFramebuffers(n, new IntPtr((long)ptr));
			}
		}

		public unsafe void glDeleteRenderbuffers(int n, int[] renderbuffers)
		{
			fixed (void* ptr = renderbuffers)
			{
				glDeleteRenderbuffers(n, new IntPtr((long)ptr));
			}
		}

		public unsafe void glDeleteTextures(int n, int[] textures)
		{
			fixed (void* ptr = textures)
			{
				glDeleteTextures(n, new IntPtr((long)ptr));
			}
		}

		public unsafe void glDrawElements<T>(int mode, int count, int type, T[] indices) where T : struct
		{
			fixed (void *ptr = indices)
			{
				glDrawElements(mode, count, type, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGenBuffers(int n, int[] buffers)
		{
			fixed (void *ptr = buffers)
			{
				glGenBuffers(n, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGenFramebuffers(int n, int[] framebuffers)
		{
			fixed (void *ptr = framebuffers)
			{
				glGenFramebuffers(n, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGenRenderbuffers(int n, int[] renderbuffers)
		{
			fixed (void *ptr = renderbuffers)
			{
				glGenRenderbuffers(n, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGenTextures(int n, int[] textures)
		{
			fixed (void *ptr = textures)
			{
				glGenTextures(n, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetBooleanv(int pname, bool[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glGetBooleanv(pname, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetFloatv(int pname, float[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glGetFloatv(pname, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetIntegerv(int pname, int[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glGetIntegerv(pname, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetActiveAttrib(int program, int index, int bufSize, out int length, out int size, out int type, System.Text.StringBuilder name)
		{
			fixed (int* lengthPtr = &length,
			       sizePtr = &size,
			       typePtr = &type)
			{
				glGetActiveAttrib(program, index, bufSize, new IntPtr((int)lengthPtr), new IntPtr((int)sizePtr), new IntPtr((int)typePtr), name);
				length = *lengthPtr;
				size = *sizePtr;
				type = *typePtr;
			}
		}

		public unsafe void glGetActiveUniform(int program, int index, int bufSize, out int length, out int size, out int type, System.Text.StringBuilder name)
		{
			fixed (int* lengthPtr = &length,
			       sizePtr = &size,
			       typePtr = &type)
			{
				glGetActiveUniform(program, index, bufSize, new IntPtr((int)lengthPtr), new IntPtr((int)sizePtr), new IntPtr((int)typePtr), name);
				length = *lengthPtr;
				size = *sizePtr;
				type = *typePtr;
			}
		}

		public unsafe void glGetAttachedShaders(int program, int maxCount, out int count, int[] shaders)
		{
			fixed (int* countPtr = &count,
			       shadersPtr = shaders)
			{
				glGetAttachedShaders(program, maxCount, new IntPtr((int)countPtr), new IntPtr((int)shadersPtr));
				count = *countPtr;
			}
		}

		public unsafe void glGetBufferParameteriv(int target, int value, int[] data)
		{
			fixed (void *ptr = data)
			{
				glGetBufferParameteriv(target, value, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetFramebufferAttachmentParameteriv(int target, int attachment, int pname, int[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glGetFramebufferAttachmentParameteriv(target, attachment, pname, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetProgramInfoLog(int program, int maxLength, out int length, System.Text.StringBuilder infoLog)
		{
			fixed (int* lengthPtr = &length)
			{
				glGetProgramInfoLog(program, maxLength, new IntPtr((long)lengthPtr), infoLog);
				length = *lengthPtr;
			}
		}

		public unsafe void glGetProgramiv(int program, int pname, int[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glGetProgramiv(program, pname, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetRenderbufferParameteriv(int target, int pname, int[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glGetRenderbufferParameteriv(target, pname, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetShaderInfoLog(int shader, int maxLength, out int length, System.Text.StringBuilder infoLog)
		{
			fixed (int* lengthPtr = &length)
			{
				glGetShaderInfoLog(shader, maxLength, new IntPtr((long)lengthPtr), infoLog);
				length = *lengthPtr;
			}
		}

		public unsafe void glGetShaderPrecisionFormat(int shaderType, int precisionType, int[] range, out int precision)
		{
			fixed (void* rangePtr = range)
			fixed (int* precisionPtr = &precision)
			{
				glGetShaderPrecisionFormat(shaderType, precisionType, new IntPtr((long)rangePtr), new IntPtr((long)precisionPtr));
				precision = *precisionPtr;
			}
		}

		public unsafe void glGetShaderSource(int shader, int maxLength, out int length, System.Text.StringBuilder source)
		{
			fixed (int* lengthPtr = &length)
			{
				glGetShaderSource(shader, maxLength, new IntPtr((long)lengthPtr), source);
				length = *lengthPtr;
			}
		}

		public unsafe void glGetShaderiv(int shader, int pname, int[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glGetShaderiv(shader, pname, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetTexParameterfv(int target, int pname, float[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glGetTexParameterfv(target, pname, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetTexParameteriv(int target, int pname, int[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glGetTexParameteriv(target, pname, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetUniformfv(int program, int location, float[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glGetUniformfv(program, location, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetUniformiv(int program, int location, int[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glGetUniformiv(program, location, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetVertexAttribfv(int index, int pname, float[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glGetVertexAttribfv(index, pname, new IntPtr((long)ptr));
			}
		}

		public unsafe void glGetVertexAttribiv(int index, int pname, int[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glGetVertexAttribiv(index, pname, new IntPtr((long)ptr));
			}
		}

		public unsafe void glReadPixels<T>(int x, int y, int width, int height, int format, int type, T[] pixels) where T : struct
		{
			fixed (void *ptr = pixels)
			{
				glReadPixels(x, y, width, height, format, type, new IntPtr((long)ptr));
			}
		}

		public unsafe void glShaderBinary<T>(int n, int[] shaders, int binaryformat, T[] binary, int length) where T : struct
		{
			fixed (void *shadersPtr = shaders,
			       binaryPtr = binary)
			{
				glShaderBinary(n, new IntPtr((long)shadersPtr), binaryformat, new IntPtr((long)binaryPtr), length);
			}
		}

		public unsafe void glShaderSource(int shader, int count, string[] str, int[] length)
		{
			fixed (void *ptr = length)
			{
				glShaderSource(shader, count, str, new IntPtr((long)ptr));
			}
		}

		public unsafe void glTexImage2D<T>(int target, int level, int internalformat, int width, int height, int border, int format, int type, T[] data) where T : struct
		{
			fixed (void *ptr = data)
			{
				glTexImage2D(target, level, internalformat, width, height, border, format, type, new IntPtr((long)ptr));
			}
		}

		public unsafe void glTexParameterfv(int target, int pname, float[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glTexParameterfv(target, pname, new IntPtr((long)ptr));
			}
		}

		public unsafe void glTexParameteriv(int target, int pname, int[] parameters)
		{
			fixed (void *ptr = parameters)
			{
				glTexParameteriv(target, pname, new IntPtr((long)ptr));
			}
		}

		public unsafe void glTexSubImage2D<T>(int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, T[] data) where T : struct
		{
			fixed (void *ptr = data)
			{
				glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, new IntPtr((long)ptr));
			}
		}

		public unsafe void glUniform1fv(int location, int count, float[] value)
		{
			fixed (void *ptr = value)
			{
				glUniform1fv(location, count, new IntPtr((long)ptr));
			}
		}

		public unsafe void glUniform1iv(int location, int count, int[] value)
		{
			fixed (void *ptr = value)
			{
				glUniform1iv(location, count, new IntPtr((long)ptr));
			}
		}

		public unsafe void glUniform2fv(int location, int count, float[] value)
		{
			fixed (void *ptr = value)
			{
				glUniform2fv(location, count, new IntPtr((long)ptr));
			}
		}

		public unsafe void glUniform2iv(int location, int count, int[] value)
		{
			fixed (void *ptr = value)
			{
				glUniform2iv(location, count, new IntPtr((long)ptr));
			}
		}

		public unsafe void glUniform3fv(int location, int count, float[] value)
		{
			fixed (void *ptr = value)
			{
				glUniform3fv(location, count, new IntPtr((long)ptr));
			}
		}

		public unsafe void glUniform3iv(int location, int count, int[] value)
		{
			fixed (void *ptr = value)
			{
				glUniform3iv(location, count, new IntPtr((long)ptr));
			}
		}

		public unsafe void glUniform4fv(int location, int count, float[] value)
		{
			fixed (void *ptr = value)
			{
				glUniform4fv(location, count, new IntPtr((long)ptr));
			}
		}

		public unsafe void glUniform4iv(int location, int count, int[] value)
		{
			fixed (void *ptr = value)
			{
				glUniform4iv(location, count, new IntPtr((long)ptr));
			}
		}

		public unsafe void glUniformMatrix2fv(int location, int count, bool transpose, float[] value)
		{
			fixed (void *ptr = value)
			{
				glUniformMatrix2fv(location, count, transpose, new IntPtr((long)ptr));
			}
		}

		public unsafe void glUniformMatrix3fv(int location, int count, bool transpose, float[] value)
		{
			fixed (void *ptr = value)
			{
				glUniformMatrix3fv(location, count, transpose, new IntPtr((long)ptr));
			}
		}

		public unsafe void glUniformMatrix4fv(int location, int count, bool transpose, float[] value)
		{
			fixed (void *ptr = value)
			{
				glUniformMatrix4fv(location, count, transpose, new IntPtr((long)ptr));
			}
		}

		public unsafe void glVertexAttrib1fv(int index, float[] v)
		{
			fixed (void *ptr = v)
			{
				glVertexAttrib1fv(index, new IntPtr((long)ptr));
			}
		}

		public unsafe void glVertexAttrib2fv(int index, float[] v)
		{
			fixed (void *ptr = v)
			{
				glVertexAttrib2fv(index, new IntPtr((long)ptr));
			}
		}

		public unsafe void glVertexAttrib3fv(int index, float[] v)
		{
			fixed (void *ptr = v)
			{
				glVertexAttrib3fv(index, new IntPtr((long)ptr));
			}
		}

		public unsafe void glVertexAttrib4fv(int index, float[] v)
		{
			fixed (void *ptr = v)
			{
				glVertexAttrib4fv(index, new IntPtr((long)ptr));
			}
		}
	}
}

	