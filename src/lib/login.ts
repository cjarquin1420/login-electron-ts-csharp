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
          console.log(err);
          if (err) {
            reject(err.message);
          } else {
            const error = Buffer.from(stderr);
            const result = Buffer.from(stdout);

            if (error.toString('utf-8')) {
              reject(error.toString('utf-8'));
            } else {
              const execResult = result.toString('utf8');
              resolve(execResult === 'Success');
            }
          }
        }
      );
    });
    console.log(result);
    return result;
  };

  const execute = async (params: ILoginRequest) => {
    return Login(params);
  };

  return {
    execute,
  };
};
