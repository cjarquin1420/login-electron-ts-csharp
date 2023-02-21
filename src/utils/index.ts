//export const sleep = (ms: number) => new Promise((resolve) => setTimeout(resolve, ms))

export enum AppOptions{
    LOGIN = 0,
}

export const jsonParse = (input: any) => {
    try {
        return JSON.parse(input)
    } catch(err) {
        console.error('Error parsing data', err)
        return undefined
    }
}