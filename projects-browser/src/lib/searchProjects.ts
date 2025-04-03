import { REPO_URL, REPO_NAME } from "../consts";

interface Project {
    name: string;
    path: string;
}

interface Subject {
    name: string;
    prettyName: string;
    projects: Project[];
    url: string;
}


const modules = import.meta.glob('/public/projects/**/index.html', { query: '?raw', import: 'default' });

export const subjects: Subject[] = (() => {
    const result: Subject[] = [];
    for (const path in modules) {
        const projectName = path.split('/').slice(-2, -1)[0];
        const projectPath = path.replace(/^\/public/, '');
        // capitalize
        const subjectName = path.split('/').slice(-3, -2)[0]
        const prettySubjectName = subjectName.charAt(0).toUpperCase() + subjectName.slice(1).replace(/-/g, ' ');
        const existingSubject = result.find(subject => subject.name === subjectName);
        if (existingSubject) {
            existingSubject.projects.push({ name: projectName, path: projectPath });
        } else {
            result.push({
                name: subjectName,
                prettyName: prettySubjectName,
                projects: [{ name: projectName, path: projectPath }],
                url: `${REPO_URL}/${REPO_NAME}/tree/main/${subjectName}`,
            });
        }
    }
    return result;
})();
