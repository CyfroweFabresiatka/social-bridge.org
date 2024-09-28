import { createQuery } from '@/data/index'
import { useFetch } from '@/fetch'

export const useProjectQuery = (productSlug: string) => {
    const fetch = useFetch();
    const { data, isLoading } = createQuery(
        ['project', productSlug],
        () => fetch.get<any>(`/api/v1/project/${productSlug}`)
    );

    return { data, isLoading };
}
