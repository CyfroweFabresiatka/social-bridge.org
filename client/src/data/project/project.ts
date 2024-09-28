import { createQuery } from '@/data/index'
import { useFetch } from '@/fetch'
import { type Project } from '@/data/project/models'

export const useProjectQuery = (productSlug: string) => {
    const fetch = useFetch();
    const { data, isLoading, error } = createQuery<Project>(
        ['project', productSlug],
        () => fetch.get<Project>(`/api/v1/projects/${productSlug}`)
    );
    
    return { data, isLoading, error };
}
