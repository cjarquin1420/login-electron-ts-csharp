import { exec } from 'child_process';

export interface ILoginRequest {
  username: string;
  password: string;
}

export const useLogin = () => {
  const currentPath =
    'C:\\Users\\cjarq\\OneDrive\\Documentos\\GitHub\\login-electron-ts-csharp\\src\\external_libs';

  const Login = async (params: ILoginRequest) => {
    const result = await new Promise<boolean>((resolve, reject) => {
      exec(
        `${currentPath}\\Login.exe \/Action:LOGINACTION \/username:${params.username} \/password:${params.password}`,
        { encoding: null },
        (err, stdout, stderr) => {
          if (err) {
            reject(err.message);
          } else {
            const error = stderr.toString('utf-8');
            const result = stdout.toString('utf-8');

            if (error) {
              reject(error);
            } else {
              const execResult = result.trim();
              resolve(execResult === 'Success');
            }
          }
        }
      );
    });

    return result;
  };

  const execute = async (params: ILoginRequest) => {
    return Login(params);
  };

  return {
    execute,
  };
};
