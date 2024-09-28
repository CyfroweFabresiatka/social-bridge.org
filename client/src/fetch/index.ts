import { env } from '@/config'

export function useFetch() {
  return {
    get: createRequest(Method.GET),
    post: createRequest(Method.POST),
    put: createRequest(Method.PUT),
    delete: createRequest(Method.DELETE),
  };
}

function createRequest(method: Method) {
  return async <T>(relativeUrl: string, data?: any) => {
    const request: RequestInit = {
      method,
      headers: {
        Accept: 'application/json',
      },
    };

    if (data) {
      request.body = JSON.stringify(data);
      request.headers = {
        ...request.headers,
        'Content-Type': 'application/json;charset=UTF-8',
      };
    }

    const url = new URL(relativeUrl, env.VITE_API_BASE_URL);
    const res = await fetch(url, request);
    
    return <T>await res.json();
  }
}

enum Method {
  GET = 'GET',
  POST = 'POST',
  PUT = 'PUT',
  DELETE = 'DELETE',
}
