import { createQuery } from '@/data'
import { loadProjects } from '@/data/home'

export const useProjectQuery = (slug: string) => {
    const { data, isLoading, error } = createQuery(
        ['project', slug],
        () => loadProject(slug)
    );
    
    return { data, isLoading, error };
}

async function loadProject(slug: string) {
    const projects = await loadProjects();
    
    return projects.find(x => x.slug === slug) ?? null;
}

/*
export function useProjectMutation() {
    const queryClient = useQueryClient()
    const onSuccess = () => queryClient.invalidateQueries({ queryKey: ['project'] })
    const fetch = useFetch();
    
    const addMutation = useMutation({
        mutationFn: (request: CreateProjectReq) => fetch.post<any>(`/api/v1/projects`, request),
        onSuccess
    })

    const editMutation = useMutation({
        mutationFn: (request: CreateProjectReq) => fetch.put<any>(`/api/v1/projects`, request),
        onSuccess
    })

    return {
        addMutationFn: addMutation.mutateAsync,
        editMutationFn: editMutation.mutateAsync
    }
}
*/
