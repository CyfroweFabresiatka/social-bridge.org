import { createQuery } from '@/data/index'
import { useFetch } from '@/fetch'

export const useHomeQuery = () => {
  const fetch = useFetch();
  const { data, isLoading } = createQuery(
    ['home'],
    () => fetch.get<Project[]>('/api/v1/projects')
  );
  
  return { data, isLoading };
}

export interface Project {
  name: string;
  slug: string;
  description: string;
}
